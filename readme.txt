Programa de terminal de autobuses, desarrollado en C# con base de datos Oracle y con Stored Procedures que mantienen la
integridad de los datos.

Comparto este proyecto ya que no es muy usual usar Oracle en tecnología .NET y por lo tanto este podría servir de guía
para aquellos que deseen implementar dicha tecnología en los frameworks .NET.

El sistema está parcialmente terminado, tiene las suficientes funcionalidades para algo relativamente básico, gracias a
la integridad de datos que mantiene Oracle, cada registro es único y no pueden ser anexados ni relacionados con nuevos
registros que se vayan a adicionar en un futuro, posee alrededor de 15 Stored Procedures que se encargan de mantener cada
registro al marguen y con una distinción única, es decir, cada chofer solo tendrá un solo autobus asignado y una sola ruta
asignada, al igual con los campos anteriores, el programa fué diseñado para evitar el cruce de datos previamente asignados
con los nuevos registros que se planean registrar en un futuro.

Este programa fué desarrollado mediante el patrón MVC, posee cuatros capas y cada una se desenvuelve en distin-
tos roles dentro del programa, como la lógica, integridad de datos, almacenamiento de datos y interface gráfica.

Me reservo el script PL/SQL de ORACLE para así evitar la clonación del proyecto para fines mal intencionados como subirlos en algún
proyecto final, tareas y etc...

Espero que este aporte pueda a ayudar a mas de uno que desee implementar la tecnología de Oracle en Frameworks .NET.




                                                                                                     Autor: Brahiam Castillo.