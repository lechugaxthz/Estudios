/* arrays */
SELECT ARRAY[1,2,3];
SELECT ARRAY[ARRAY[1,2,3], ARRAY[4,5,6]];

/* creado de consultas con arrays  */
CREATE TEMP TABLE arr AS SELECT ARRAY[0,1,2] int_arr;
SELECT int_arr[1] FROM arr;
/*  
    tener en cuenta que estas forman un array 
    dentro de una CTE (common table expression) 
    la cual contiene a esta variable int_arr dentro
    de ella con el valor de ARRAY[0,1,2]
*/

/*  
    dato importante, las arrays en SQL
    se consultan desde el 1, no desde el 0 !!!
*/

SELECT int_arr[1:5] from arr;
/* 
    al igual que otros lenguajes, en sql
    se pueden consultar por un recorte de
    los datos en una array[<desde>:<hasta>]
    /   -desde : punto inicial (posición)
        -hasta : punto inclusive al que llegar
    cabe destacar que si ponemos un valor que 
    sobrepasa el limite de nuestra array, devolverá
    hasta el ultimo valor, no espacios nulos
*/

SELECT ARRAY_DIMS(int_arr) from arr;
/* 
    como bien lo dice el nombre, devuelve la
    dimensión de la array que tenemos acá
    de forma [<inicio>:<fin inclusive>]
*/

SELECT ARRAY_LENGTH(int_arr,1) from arr;
/* 
    devuelve la longitud de la array
    recibiendo como parametros
        - array
        - posición de la misma
    ya que un array puede ser uni o multi dimensional
*/

SELECT CARDINALITY(int_arr) from arr;
/* 
    a diferencia de array_length(), este
    devuelve la cantidad de elementos dentro del
    array independientemente de su dimensión,
    pudiendo tener un [n1,n2], donde n es un
    arrya con cantidad de elementos dentro,
    entonces cardinality te devuelve la cantidad 
    de elementos totales sumados de cada n dentro del
    array principal
*/

/* Dates, Timestamps, Intervals */
SELECT (DATE_TRUNC('MONTH', TO_DATE('201608'||'01', 'YYYYMMDD')) + '1 MONTH - 1 DAY') :: DATE;
/*
    DATE_TRUNK (<enum>, <fecha>):
        el enum va desde 'year' hasta 'second'.
        lo que hace es tomando este <enum> y la <fecha>
        de tipo 'date' agarrar a <fecha> y devolver la misma
        a modo de rebajar al minimo valor a partir de <enum>

        ejemplo: date_trunk('YEAR', <fecha>) = '<año>-01-01 00:00:00'
    
    (<str date>) :: DATE:
        transforma esta str en un tipo DATE pero tiene que tener:
            '<year><month><day><hora>' para hacer a topo DATE
    
    TO_DATE(<date>, <format>):
        pasa a tipo DATE con la diferencia (respecto al anterior)
        de que no pueden haber errores como con DATE, porque una fecha
        puede estar como 'YYYYMMDD', 'DDMMYYYY' ' O 'YYYYDDMM' entre otras
        lo cual en este le definimos éso como <format>
*/
CREATE TEMP TABLE fecha as SELECT current_timestamp this_time;
SELECT this_time from fecha;
/* para no andar creando fechas constantemente */

SELECT TO_CHAR((SELECT this_time FROM fecha):: TIMESTAMP, 'dd Mon yyyy hh:mi:sspm');
/* 
    TO_CHAR(<date>, <format>):
        el formato puede ser el qeu nosotros querramos
        tener en cuenta los caracteres
        'yyyy' 'mm' 'dd' 'hh' 'mm' 'ss'

        tener en cuenta:
            a esta función se le puede pasar muchas formas el formato
            porque mas que un formato es un texto donde podemos usar
            esos caracteres que nombramos anteriormente. como...: <funcion siguiente>
*/
SELECT TO_CHAR((SELECT this_time FROM fecha):: TIMESTAMP,
                '"Estamos a "FMDia", de "DDth" día del mes "FMMonth" of "yyyy');
/* 
    inclusive podemos "formatear" junto con una String//CHAR que qeurramos, dando
    forma al texto en nuestras consultas.
    Estas solo pueden ir dentro de "<mi texto>" (comillas dobles)
*/

/* Tablas */

/* 
    para consultar la informacion columnas y tipos de tablas particulares
    lo hacemos mediante el comando (en terminal)
        \d <tabla>
    y si queremos información mas detallada
        \d+ <tabla>
*/

/* Creado de tablas */

/*
    ya sobre creado de tablas hemos visto unos ejemplos al crear tablas
    "temporales" para ejercicios anteriores
*/

/* 
    recomendación!!! CREAR SIEMPRE LAS TABLAS COMO 
    <tabla> y no <Tabla> porque
    al hacer llamados de estas <Tablas> vamos a tener que
    indicar "<Tabla>" en la consulta y no solo usar <tabla>
*/

CREATE TABLE persona (
    persona_id BIGSERIAL NOT NULL, -- o tambien puedes poner PRIMARY KEY acá mismo
    nombre VARCHAR(25) NOT NULL,
    apellido VARCHAR(25) NOT NULL,
    edad INT NOT NULL,
    PRIMARY KEY (persona_id),
    CHECK (edad >= 0)
);

/* 
    tambien podemos crear una tabla a base de personas que cumplan
    una "x" condicion mendiante...
*/

CREATE TABLE persona_mayor AS SELECT * FROM persona WHERE edad >= 18;

/* 
    indicando así que solo tomaremos a todas las personas de persona cuya edad sea mayor igual a 18
*/

/* tablas no registradas o "unlogged table" */

CREATE UNLOGGED TABLE person2 (
    persona_id BIGINT NOT NULL PRIMARY KEY,
    nombre VARCHAR(25) NOT NULL,
    apellido VARCHAR(25),
    ubicacion VARCHAR(50),
    ciudad VARCHAR(25)
);

/* Referencias */

CREATE TABLE data_personal (
    id BIGSERIAL PRIMARY KEY NOT NULL,
    pais VARCHAR(25),
    ciudad VARCHAR(90),
    calle VARCHAR(100),
    altura INT,
    piso INT,
    persona_id BIGSERIAL NOT NULL REFERENCES persona(persona_id) DEFERRABLE INITIALLY DEFERRED
);

/* consultas SELECT usando WHERE */

/*
    consiste en consultas de tipo

        SELECT <datos> FROM <schema>.<tabla> WHERE <condicion>;

        donde :
            - datos :
                son aquellas cosas que queremos obtener de la <tabla>
                puede ser "*" como puede ser "<columna>, <columna>..."
            - schema :
                estructura que organiza y agrupa objetos de bases de datos,
                como las tablas, vistas, indices, funciones y demás.
                estos ayudan a organizar y administrar los objetos de la
                base de datos de manera mas eficiente.
            - tabla :
                contenedor de los datos que queremos consultar dentre sus
                columnas
            - condicion :
                va por partes como :
                    <columna> = // != <dato> (con posiblidad de usar "AND" y mas consulta)

*/


/* INSERT */

/* con : */
CREATE TABLE  raza_gatos (
    id BIGSERIAL PRIMARY KEY NOT NULL,
    nombre VARCHAR()
);
