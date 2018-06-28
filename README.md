# MANUAL DE USUARIO

## Manual en formato PDF con ímagenes
https://github.com/suarezoscar/logoquizz/blob/master/Manual%20de%20usuario%20Logo%20Quiz.pdf

## Logo Quizz

### INTRODUCCIÓN AL JUEGO.

En este juego varios jugadores compiten para adivinar lo antes posible la marca de un logo que se va
“despixelando” en pantalla.

El jugador tendrá un tiempo limitado para contestar, y cuanto más tarde en hacerlo menos puntos recibirá.

Una vez todos los jugadores hayan contestado o se les haya acabado el tiempo,

se muestra las puntuaciones por pantalla y se inicia una nueva ronda.

Hay 2 formas de ganar la partida:

- Ser el primero en alcanzar la puntuación establecida para ganar.
- Si nadie alcanza la puntuación establecida, se declara ganador el que más puntos tenga al finalizar todas las
rondas.

### Índice

- Manual SERVIDOR
- Manual CLIENTE


## USO DEL SERVIDOR

```
Estado del servidor, indica si está
activo o apagado.
```
```
Botón de inicio o apagado del
servidorPuerto por el cual el servidor va
recibir las peticiones de los clientes.
```
#### CONFIGURACION DE LA PARTIDA:

```
Permite configurar los parámetros
de cada partida, se tiene que
configurar antes de iniciar el
servidor.
Jugadores máximos : limita el
número máximo de jugadores en
una partida.
Puntuación máxima : Termina la
partida cuando algún jugador
alcanza la puntuación indicada.
Rondas por partida Termina la
partida cuando se acaban las
rondas indicadas.
Tiempo de ronda: configura el
tiempo de rondas en segundos.
```

```
a
```
Consola del servidor

```
Apagar el servidor
```
```
Si el servidor se inició correctamente, su estado pasa a ser
ACTIVO.
La consola indica el número de imágenes que fueron
cargadas.
El servidor está listo para recibir jugadores.
```

#### .

```
Lista de jugadores conectados.
Muestra el Nick, la IP y el puerto de
escucha de cada jugador
```
```
Permite echar fuera de la partida un
jugador previamente seleccionado en la
consola.
```

## USO DEL CLIENTE

```
Lo primero que tienes que hacer es conectarte al servidor, para eso vete a:
Archivo  Conectar  Conectarse al servidor (el puerto por defecto es 2000) cambiar
la IP por la del servidor.
```
```
Estado de la conexion
```
```
Una vez introducido la
ip y el puerto pulsa
para conectarte
```
```
Desconectarse d Entrar en
la sala de chat: una vez
conectado correctamente
introducir un Nick para
entrar al chat el servidor
```
```
Cerrar el juego
```
```
Entrar en la sala de chat: una vez conectado
correctamente introducir un Nick para
entrar al chat
```
```
IP del servidor
```
```
Puerto de escucha del servidor
```

```
Enviar un mensaje de chat puedes enviar un
mensaje pulsando ENTER o haciendo clic en
el botón enviar
```
```
Los mensajes de chat
aparecen aquí
```
```
Una vez que estés listo
para jugar pulsa el botón
verde “Estoy listo”.
Cuando todos los
jugadores estén listos
empezará la partida
```
```
¡Atento a las pistas! Los guiones representan el número de
letras, según pasen los segundos se irán revelando letras.
```
```
Ronda Actual
Tiempo restante para
que finalice la ronda
```
```
Todo el mundo podrá ver tus
intentos de adivinar el logo.
```
Las respuestas se envían de la misma forma que un mensaje de chat,
pero el modo respuesta tiene que estar seleccionado,
(Se activa automáticamente al inicio de cada ronda).


Al final de cada partida se mostrará el ganador
(o ganadores en caso de empate) La clasificación general se muestra aquí, y se actualiza al final de cada

```
ronda.
```
```
Una vez finalizada la partida puedes decidir si quieres
jugar otra dándole otra vez al botón “Estoy listo!”.
```

