# **UPSTREAM**

## **Tapeo Games**

Javier Álvarez Perez

Lucas Rubio Lezana

Yeray da Silva de las Heras

Javier de las Peñas Fernandez

Luna Bouzón Rodríguez

**ÍNDICE**

2. Introducción

3. Visión del Juego

4. Mecánicas del Juego

5. Personajes

6. Mundo y Entorno

7. Historia y Narrativa

8. Arte y Gráficos

9. Sonido y Música

10. Interfaz de Usuario (UI)

11. Mecánicas de Juego

12. Controles

13. Tecnología y Plataforma

14. Modelo de Negocio


# INTRODUCCIÓN

El propósito del siguiente Game Design Document es proporcionar una visión general detallada de nuestro proyecto de videojuego, " **Upstream**". Este GDD servirá como hoja de ruta esencial para el desarrollo y diseño de nuestro juego, destacando la trama principal y las subtramas que darán vida a esta experiencia única.

**Upstream** es un videojuego 3D single-player para web que impulsa el pensamiento computacional en niños. El juego cuenta con diversos niveles a lo largo de los cuales el jugador será capaz de observar el desarrollo y crecimiento de Darwin, nuestro protagonista. Es un juego de tipo puzzle en el que el jugador deberá desplazarse por el escenario esquivando y desplazando obstáculos para llegar a una meta final, la cual representa el hogar de dichos anfibios.

# VISIÓN DEL JUEGO

El propósito central de " **Upstream**" es combinar la diversión y la educación de una manera cautivadora, utilizando un enfoque de juego que promueva el pensamiento computacional en niños. El juego está diseñado para involucrar a los jugadores en una experiencia emocionante mientras exploran conceptos clave de la programación y la resolución de problemas. A través de la historia de Darwin, el pequeño anfibio, los jugadores aprenderán sobre la importancia de la adaptación, la planificación estratégica y la superación de desafíos.

El objetivo principal del juego es guiar a Darwin a lo largo de su viaje de regreso a casa en el riachuelo. Cada nivel presenta un escenario lleno de obstáculos y desafíos que el jugador debe superar. Estos desafíos no solo son físicos, sino también cognitivos, ya que los jugadores deben idear estrategias para resolver problemas y tomar decisiones informadas para avanzar en el juego.

El juego tiene un tono generalmente optimista y educativo, que combina la emoción de una historia de supervivencia con elementos de descubrimiento y resolución de problemas. El juego trata temas como la adaptación, la evolución y la importancia de la naturaleza en nuestras vidas. El tono es amigable y accesible para niños, con un enfoque en la diversión y el entretenimiento, pero también en la educación.

El público objetivo principal de " **Upstream**" son niños y preadolescentes en edades comprendidas entre los 7 y los 12 años. Está diseñado específicamente para ser una herramienta educativa divertida que se integre en el aprendizaje informal. El juego se adapta a un nivel de habilidad y comprensión apropiado para esta franja de edad, lo que facilita que los niños puedan participar y disfrutar de la experiencia sin sentirse abrumados.

Además del público infantil, " **Upstream**" también puede atraer a padres, maestros y cuidadores interesados en ofrecer a los niños una experiencia de juego educativa y enriquecedora.

En un principio se plantearon los siguinetes MOODBOARDS:

![moodboard 1](https://github.com/tapeogames/Upstream/assets/145482203/0ca1c3ec-6fa9-45bd-858f-6ab5b239ae6e)
![moodboard 2](https://github.com/tapeogames/Upstream/assets/145482203/bf84fa6e-e8bc-4db2-8e33-fbd1da57dc9e)


# NARRATIVA

## Trama principal y subtramas

La narrativa central del juego trata sobre la aventura de un pequeño anfibio llamado Darwin durante el regreso con su familia. Esta especie de anfibios similares a las salamandras habita en riachuelos, donde depositan sus huevos y los dejan fluir río abajo. El objetivo es que, al eclosionar, las nuevas generaciones se enfrenten a los desafíos que encuentren en su viaje de regreso a casa.

Acompañaremos a Darwin a lo largo de este viaje, donde deberá ingeniárselas para superar las dificultades del camino. Además veremos su crecimiento, ya que irá transitando por las diferentes fases de la metamorfosis, aprendiendo y ganando experiencia en su travesía.

También se cruzará con diferentes criaturas, de las cuales algunas serán obstáculos a evitar, mientras que otras necesitarán de su ayuda.

## Entornos

Los diversos escenarios del juego tendrán un papel narrativo que reflejará la perspectiva de Darwin sobre su situación a medida que crece y aprende .

Mientras es un renacuajo, se verá abrumado por la situación y se sentirá en un peligro constante. En consecuencia, los escenarios adoptarán un aspecto más sombrío y amenazante, con formas triangulares, colores fríos y una tenue iluminación. Estos representarán la cueva donde se estancó el huevo al ir río abajo.

En su siguiente fase, ya posee más experiencia y comenzará a ver las cosas de manera diferente, donde no todo son obstáculos de gran peligro. Los ambientes se iluminarán con colores más cálidos, evocando un amanecer, las formas serán más redondeadas, aunque se mantendrán elementos de la estética anterior. Darwin ha salido de la cueva y empieza a descubrir la naturaleza exterior del riachuelo.

Finalmente, al comienzo de su etapa adulta, Darwin ya tiene más conocimiento y percibe su entorno, peligros y dificultades de forma más realista. Por ello los escenarios adquirirán una apariencia más acogedora, con una iluminación diurna, colores más naturales y las formas amigables prevalecerán sobre las agresivas.

# PERSONAJES

El juego contiene un único personaje principal, Darwin, controlado por el usuario, aunque también se incluyen NPCs.

## Darwin

Como ya se ha mencionado en el apartado de narrativa, Darwin pertenece a una especie de anfibios que atraviesan un proceso de metamorfosis, similar al de las ranas y sapos. Comienzan su crecimiento como renacuajos y poco a poco evolucionan hasta convertirse en salamandras con patas y cola. Las consecuencias en el juego de este concepto se explican con más detalle en el apartado de mecánicas, ya que cada estado de la evolución de Darwin permitirá al jugador aplicar distintas mecánicas de juego en los niveles.

Pese a la cantidad de adversidades a las que se debe enfrentar, Darwin posee una personalidad relajada y alegre. Esto se puede apreciar en su constante sonrisa y naturaleza tranquila.

## NPCs

Pese a que el único personaje al que puede controlar el jugador es Darwin, se pretende incluir algunos NPCs que aparecerán en distintos niveles para ofrecer ayuda al jugador u obstaculizar su camino. Algunos de ejemplos son los siguientes:

- Patos:

En algunos niveles, una de las casillas estará ocupada por una mamá pato y otra, notablemente alejada de la anterior, por un patito. Se mostrará visiblemente cómo la mamá pato llora por no tener a su cría con ella, por lo que el jugador deberá conseguir llegar a la cría y arrastrarla o empujarla hasta la madre. Una vez los patos se hayan reunido, se recompensará al jugador, ya sea permitiéndole paso directamente a la salida del nivel o ayudándole con otra tarea.

- Sapos:

El jugador se encontrará con ellos en ciertos niveles en los que un sapo ocupará una casilla y estará croando, provocando vibraciones en el agua que no permitirán pasar a Darwin. Sin embargo, este obstáculo se puede sobrepasar si Darwin le lleva una mosca al sapo, el cual al empezar a comérsela, dejará de croar.

# MUNDO Y ENTORNO

La principal característica del entorno de juego es que este está diseñado para que el movimiento no sea libre, sino por cuadrículas. Esta decisión de diseño se debe a la naturaleza del juego, ya que como este está basado en puzzles, quisimos hacer que hubiese casillas de juego para que el usuario pueda resolverlos de forma más lógica para que pueda desarrollar de forma más efectiva su pensamiento computacional.

Los niveles tendrán su espacio de juego transitable y por otra parte, zonas por las que el jugador no podrá transitar. Siendo acorde a la narrativa, los primeros niveles a los que se enfrentará el jugador, correspondiente a su primera fase evolutiva, son dentro de una cueva oscura y sombría, donde la zona transitable sólo será el agua y los lugares por donde no podrá pasar serán rocas. Poco a poco se irán introduciendo distintos elementos que dan a entender que Darwin está saliendo al exterior, que es la siguiente fase del videojuego.

En la segunda fase se mezclarán elementos del exterior como plantas o troncos con rocas y zonas más oscuras, aunque como en la fase anterior, poco a poco se introducirán elementos que den pie a la siguiente fase. La zona transitable será ahora tanto el agua como algunas zonas de tierra o roca, por las que Darwin se podrá deslizar, pero no caminar y además tampoco podrá escalar superficies.

En la última fase, Darwin ha salido al exterior y se encontrará con elementos tanto naturales como hechos por el hombre, como pueden ser botellas de plástico, neumáticos o barriles. La ambientación al ser en el exterior consta de colores más vibrantes y saturados.Las zonas transitables serán agua y tierra, sumandole la verticalidad ya que podrá escalar, pero Darin no podrá moverse por casillas que estén contaminadas o donde haya depredadores que le puedan comer.

Durante las diversas fases el jugador se irá encontrando con NPCs cuyo diseño será acorde al espacio de juego del nivel, es decir, se podrá encontrar con aves en la tercera fase, desarrollada en el exterior, pero no en la primera ya que está en la cueva. Además, la complejidad de los escenarios y de sus puzzles se irá complicando a lo largo de los niveles, haciendo así que el jugador se enfrente a nuevos retos.

# ARTE Y GRÁFICOS

## Estilo visual y gráficos

"Upstream" es un videojuego de gráficos 3D que presenta una perspectiva isométrica con cámara fija. Su estilo visual persigue una estética estilizada de tipo "cartoon".

El juego estará dividido en niveles individuales donde, a medida que Darwin avance por el riachuelo, la ambientación cambiará adecuándose a este progreso. Además, como se ha explicado anteriormente, la atmósfera de los escenarios irá cambiando con el objetivo de transmitir los sentimientos y el punto de vista de Darwin durante su proceso de crecimiento.

**Arte conceptual** ![Darwin Evo 1 - Turn Around](https://github.com/tapeogames/Upstream/assets/145482203/e6413e1a-47e4-4686-8069-42537256b5e3)


# MÚSICA Y SONIDO

**Música:**

La música desempeña un papel vital en la experiencia de juego y la inmersión de los niños en nuestro juego de puzles. A continuación, se detallan las directrices relacionadas con la música:

- **Música Temática:** Se creará una música principal distintiva que se repetirá a lo largo del juego. Esta música debe ser alegre, amigable y estimulante para mantener la atención de los niños.

- **Variación de Pistas:** Además de la música principal, habrá pistas musicales específicas para momentos como la selección de niveles, logros y victorias en los puzles. Todas estas pistas seguirán el tono general del juego.

- **Instrumentos y Sonidos Amigables** : Los instrumentos y sonidos utilizados serán familiares y atractivos para los niños, como campanas, flautas, xilófonos.

- **Loops Continuos:** Todas las pistas de música se diseñarán como loops para garantizar una transición fluida y sin interrupciones durante el juego.

**Efectos de Sonido:**

Los efectos de sonido son fundamentales para brindar retroalimentación y vida al mundo del juego. Aquí están las directrices para los efectos de sonido:

- **Interacción en el Juego:** Cada acción de los jugadores, como mover troncos en un escenario o interactuar con botones, generará efectos de sonido correspondientes. Esto mejora la interacción y la inmersión.

- **Efectos de Sonido Temáticos** : Los efectos de sonido serán amigables y acordes al estilo del juego, utilizando sonidos alegres y simpáticos.

- **Feedback Positivo:** Cuando los niños resuelvan niveles o alcancen logros, se utilizarán efectos de sonido que refuercen de manera positiva su éxito, como aplausos o una música alegre.

- **Feedback Negativo:** En caso de errores, se implementarán efectos de sonido suaves y amigables en lugar de sonidos severos o punitivos, con el objetivo de mantener un ambiente de juego positivo y de aprendizaje e instar a que vuelvan a intentarlo.

- **Ajustes de Volumen:** Se proporcionará la opción de ajustar el volumen de música y efectos de sonido en el menú de configuración del juego para garantizar la comodidad de los jugadores.

La música y los efectos de sonido serán diseñados específicamente para asegurar que contribuyan a una experiencia de juego divertida y apropiada para los niños, manteniendo un ambiente alegre y amigable en todo momento.

# INTERFAZ DE USUARIO

Una interfaz en un juego, a menudo llamada "interfaz de usuario" o "UI", se refiere a todos los elementos visuales y gráficos que permiten a los jugadores interactuar con el juego y obtener información sobre su progreso, opciones y estado actual. La interfaz de usuario es una parte esencial de cualquier juego y desempeña un papel crucial por varias razones entre las que destacan la facilidad ante la comunicación, la inmersión que proporciona, el control y la navegación que provee, etc.

En el proceso de desarrollo de las interfaces de nuestro juego, hemos establecido un objetivo central: diseñar interfaces de usuario que sean intuitivas, fáciles de entender y simples de navegar. Reconocemos que nuestro público principal está compuesto por jugadores más jóvenes, y es esencial que disfruten de una experiencia de juego sin complicaciones desde el primer momento.

**Diagrama de flujo de Interfaces**

En el juego Upstream, la primera interacción que los jugadores encontrarán es una pantalla inicial en la que deberán proporcionar su edad y género. Una vez ingresada está información, la pantalla mostrará el distintivo logo de Tapeo Games.

Después de la presentación del logo, los jugadores serán llevados al menú principal del juego. Si desean comenzar su aventura, simplemente deberán presionar el botón "Jugar" en el menú.

Al seleccionar "Jugar", los jugadores serán transportados a la trama principal del jeugo. Una pantalla narrativa desplegará la historia que los sumergirá en el mundo de Upstream. Después de conocer el contexto, los jugadores podrán elegir su nivel a través de un selector de niveles.

Una vez el jugador se encuentre en el juego tendrán en todo momento la opción de pausar el juego, simplemente presionando el botón de pausa. Esto abrirá una pantalla de pausa, donde podrán ajustar configuraciones o tomar un breve descanso.

Finalmente, cuando los jugadores superen un nivel, serán llevados a una pantalla de victoria donde se le capacitará al jugador ir al siguiente nivel.

#

![Diagrama flujo 1](https://github.com/tapeogames/Upstream/assets/145482203/7b8664cc-6463-4960-8316-46a3988f78fe)


**Interfaz de la pantalla inicial**

En esta interfaz los jugadores podrán personalizar su experiencia de juego seleccionando su edad y género.

Al hacer clic en el botón correspondiente a la edad, los jugadores podrán seleccionar, mediante un desplegable, su edad.

Asimismo, para elegir su género, se han proporcionado tres opciones: "Masculino", "Femenino" y "Otro".

![Diagrama flujo 2](https://github.com/tapeogames/Upstream/assets/145482203/75511079-8eec-400d-86e3-68e05bf91a64)


**Interfaz del menú de inicio**

En el menú de inicio de Upstream, los jugadores se encontrarán con una serie de botones entre los cuales se encuentra el de "Jugar", el cual te llevará directamente a la trama del juego. Al hacer clic en él se te dirigirá a la historia del juego donde, posteriormente, podrás

seleccionar el nivel.

Si prefieres ajustar las configuraciones del juego o consultar los controles antes de comenzar, el segundo botón, "Ajustes", será tu elección. Aquí podrás ajustar el volumen del juego a tu preferencia, asegurándote de que la experiencia auditiva se adapte a tus necesidades. Además, podrás encontrar una sección dedicada a los controles, donde podrás revisar y familiarizarte con las teclas y los comandos necesarios para poder jugar al juego de manera correcta.

El tercer botón, "Créditos", se encontrará la información sobre los desarrolladores, diseñadores y creativos que trabajaron en el juego, así como cualquier otra contribución destacada.

Finalmente, si deseas cerrar el juego y volver al escritorio o al menú principal de tu plataforma de juego, el cuarto botón, "Salir", te permitirá hacerlo de manera rápida y sencilla.

![Diagrama flujo 3](https://github.com/tapeogames/Upstream/assets/145482203/7e0b108f-f7f9-4cd5-ba39-82a550de1bbf)


**Interfaz del selector de niveles**

En la interfaz del selector de niveles de Upstream, los jugadores encontrarán un mapa donde podrán hacer clic en el nivel que deseen jugar. Este mapa está diseñado para facilitar la elección de niveles de manera sencilla y visualmente atractiva.

Cuando los jugadores accedan a esta pantalla, observarán un mapa que representa el mundo del mundo. En este mapa, se mostrarán varios niveles y ubicaciones importantes.

Para seleccionar un nivel en particular, los jugadores simplemente deberán hacer clic en el icono correspondiente. Una vez seleccionado, el juego los llevará directamente al nivel elegido.

**Interfaz del menú de pausa**

Dentro del menú de pausa, encontrarás cuatro botones esenciales que te permitirán tomar el control de tu experiencia de juego de manera sencilla y conveniente.

En primer botón, "Reanudar", te permitirá retomar el jeugo desde el punto en el que lo dejaste, continuando el nivel exactamente donde lo dejaste.

El segundo botón, "Ajustes", te brindará la posibilidad de modificar el volumen del juego a tu gusto.

Si en algún momento necesitas recordar los controles o deseas consultarlos para mejorar tu destreza en el juego, el tercer botón, "Controles", te llevará a una sección donde encontrarás toda la información necesaria sobre cómo navegar e interactuar en Upstream.

Finalmente, si deseas abandonar el nivel actual y regresar al menú de inicio para explorar otras opciones o seleccionar un nivel diferente, el cuarto botón, "Salir", te permitirá hacerlo.

![Diagrama flujo 4](https://github.com/tapeogames/Upstream/assets/145482203/479d44f0-3eab-40f8-9473-2c9cd0c4315a)


**Interfaz del menú de victoria**

En el menú de victoria se encontrarán dos botones fundamentales que te permitirán decidir cómo proceder después de completar un nivel.

El primer botón, identificado como "Siguiente Nivel", te llevará al siguiente nivel en la secuencia de la historia del juego.

Si en cambio prefieres volver al punto de inicio o explorar otras opciones disponibles en el jeugom el segundo botón, señalado como "Menú Principal", te llevará de vuelta al menú principal del juego.

![Diagrama flujo 5](https://github.com/tapeogames/Upstream/assets/145482203/e05b4985-5e65-44a7-a1fa-7c8b0de9320d)


# MECÁNICAS DE JUEGO

A lo largo del juego, se irán presentando diferentes mecánicas de progresión para incrementar la dificultad de los niveles y presentar un reto al jugador, que deberá saber cómo aplicarlas para poder avanzar.

La primera mecánica principal es el movimiento. El jugador podrá moverse en las 4 direcciones cardinales y además podrá escalar objetos que tengan un relieve considerable. A través del diseño de niveles se hará que esta mecánica sea necesaria para completar los niveles. Esta será la mecánica clave del videojuego ya que el objetivo es que el jugador sepa llegar hasta cierto punto del escenario esquivando todos los obstáculos y moviendo objetos para situarlos a su favor.

Otra mecánica del juego es el arrastrar y empujar objetos como pueden ser troncos, barriles, nenúfares… etc. Los niveles se diseñarán con el objetivo de mantener este concepto pero aumentando la complejidad del mapa para que el usuario necesite pensar sus movimientos y planear en su cabeza cómo resolver el puzzle.

Cabe destacar también que Darwin podrá aprovechar ciertas superficies para deslizarse y avanzar varias casillas, en lo referido a la tierra, y además podrá aprovechar corrientes del agua para el mismo fin.

El personaje contará con un sistema de progresión de mecánicas que irá relacionado con la etapa evolutiva en la que se encuentra el personaje, estas serán tres:

- Renacuajo: en esta etapa Darwin solo podrá ir por el agua ya que sus patas son demasiado pequeñas como para poder salir del agua, la única mecánica que destaca es la del movimiento, que en este caso no tendrá verticalidad.

- Renacuajo adulto: durante esta etapa el personaje podrá nadar por el agua y además podrá salir a la tierra y deslizarse por ciertos bloques, pero no podrá caminar porque sus patas no son suficientemente fuertes. También podrá empujar cosas pequeñas por el agua, como palos, hojas etc…

- Salamandra: en esta etapa Darwin habrá alcanzado su estado de evolución completo por lo que podrá moverse por todos los terrenos y además podrá escalar por ciertas zonas. También podrá mover objetos tanto pequeños como grandes.

En cuanto a los controles del juego, para ordenador, se podrá mover a Darwin con WASD y para interactuar con un objeto y arrastrarlo, habrá que pulsar y mantener el espacio. Para movil (pendiente consulta por dificultad de implementación)

#

# CONTROLES

" **Upstream**" cuenta con interfaces navegables con cursor y teclado, con un click se podrá acceder a la ruta querida. En la próxima entrega del juego está previsto meter la navegabilidad en el móvil, haciendo que con pulsar una vez se entre en el lugar querido.

Actualmente, como no contamos con una implementación final, los controles básicos del personaje serán los siguientes:

![wasd](https://github.com/tapeogames/Upstream/assets/145482203/67a7b706-e7da-4c12-944e-9fad2ede1a90)


Este será para el movimiento en el mundo virtual en el eje xz. En este caso, **A** será izquierda; **D** , derecha; **W** , arriba y **S** , abajo. Además, el personaje tendrá la posibilidad de empujar algunos objetos interactuables con la tecla **P** , y este objeto se moverá en dirección en la que mire el personaje y se pulse la tecla. Además, si se mantiene pulsada la misma tecla, también habrá la posibilidad de arrastrar hacia el sentido trasero del personaje. Esto será inicialmente así en ordenador, pero está previsto añadir también controles para móviles, que aún están por determinar.

# TECNOLOGÍA Y PLATAFORMA

En nuestro proyecto de desarrollo de videojuegos, hemos seleccionado Unity como el motor de juego principal que impulsará la creación y experiencia de juego. Unity, en su versión 2022.3.10, es una elección estratégica que se basa en su renombrada flexibilidad y capacidades técnicas avanzadas.

La selección de Unity como motor de juego se da debido a su amplia comunidad y recursos, lo cual nos permite un amplio conjunto de herramientas y conocimientos para agilizar el desarrollo, su potencia gráfica, su versatilidad de desarrollo, permitiendo así tanto proyectos 2D como 3D, además de su sistema de scripting en C# el cual es altamente flexible y versátil. Además, cabe destacar sus continuas actualizaciones y el hecho de que es multiplataforma, contando con una gran capacidad para exportar juegos a una variedad de plataformas, desde PC y consolas hasta dispositivos móviles y realidad virtual.

En resumen, Unity 2022.3.10 es la elección perfecta para impulsar nuestro juego. Con este motor estamos seguros de que podemos llevar a cabo nuestro proyecto de manera efectiva y brindar una experiencia de juego excepcional a nuestros jugadores.

Para garantizar que todos los jugadores puedan disfrutar de nuestra experiencia de juego de la mejor manera posible, es esencial proporcionar información detallada sobre los requisitos técnicos necesarios para ejecutar el juego de manera óptima.

Estos requisitos son fundamentales para asegurarnos de que la experiencia de juego sea fluida, inmersiva y accesible para una amplia variedad de configuraciones de hardware.

Tanto para poder jugar en PC como en dispositivos móviles, dos de los requisitos fundamentales serán, tener espacio de almacenamiento para poder descargar así el juego y, tener acceso a internet, ya que, si el cliente no tiene forma de acceder a la página desde la que se descarga el videojuego, no tendrá forma de jugarlo.

Las plataformas de lanzamiento son una parte esencial de la estrategia de distribución de nuestro juego. En esta sección, se detalla las diferentes plataformas en las que se lanzará el juego para llegar a la audiencia más amplia posible. Además, se indicará la plataforma de distribución que facilitará a los jugadores la descarga y el acceso al juego.

Una de las plataformas de lanzamiento será PC, disponible para el sistema operativo de Windows, aprovechando así la potencia de los ordenadores para ofrecer una experiencia de juego de alta calidad.

Otra de las plataformas serán los dispositivos móviles, en concreto para Android. Cabe destacar que es una de las plataformas más activas a día de hoy con una amplia audiencia potencial y accesibilidad, de forma que, los jugadores pueden acceder y jugar al juego en cualquier lugar y momento, lo que aumenta la oportunidad de retener a los jugadores.

Además de las plataformas de lanzamiento conviene enfatizar la plataforma de distribución por la que se facilitará el acceso y la descarga del juego, Itch.io. De esta forma los jugadores podrán adquirir y descargar el juego directamente lo que proporcionará una experiencia de usuario fluida y sencilla.

Esta estrategia de lanzamiento y distribución se alinea con nuestro objetivo de hacer que el juego esté disponible para una amplia variedad de plataformas, brindando a los jugadores la flexibilidad de elegir dónde y cómo quieren disfrutar de nuestra creación.

# MODELO DE NEGOCIO

##

## Información de usuario

El usuario, o persona que jugará a Upstream, será una persona con edad comprendida entre 5 y 12 años. Es un niño que tiene cuenta con dos padres y un hermano de las mismas edades. Mantiene una buena relación con ellos y con todo su entorno. Es bastante competitivo, tanto que le gusta ver con sus amigos quién es mejor en videojuegos. Es una persona con bastante interacción social, ya que tiene tanto actividades escolares como extraescolares. Está un poco aburrido de hacer lo mismo de siempre, fútbol, baloncesto… Le gusta todo lo relacionado con los ordenadores. Por ello, quiere alguna actividad que de verdad le entretenga y le divierta.

## Mapa de empatía

Un mapa de empatía en modelos de negocio es una herramienta visual que ayuda a comprender mejor a los clientes o usuarios de un producto o servicio. Esta herramienta se utiliza en el proceso de diseño de negocios para desarrollar una comprensión más profunda de las necesidades, deseos, motivaciones y frustraciones de los clientes. El objetivo es ponerse en el lugar del cliente para poder crear productos o servicios que realmente satisfagan sus necesidades y expectativas.

Ejemplo de mapa de empatía desde el punto de vista de un niño que juega al juego:

1.¿Qué piensan y sienten?

Los niños a estas edades (Aprox 6-10 años) piensan, fundamentalmente, en divertirse mientras juegan, quieren sentirse desafiados mientras logran éxito a medida que va avanzando el juego.

Además, cabe destacar que se sienten emocionados cuando encuentran personajes o mundos llamativos para ellos.

2.¿Qué ven?

Debido a la gran evolución y expansión de los videojuegos, a día de hoy, cualquier persona puede jugar a juegos, independientemente de la edad que pueda tener el cliente. Asimismo, lo que el niño ve son anuncios de juegos en línea y en la televisión, ven también a amigos y compañeros de clase jugando videojuegos o, también, ven a sus padres y maestros animándolos a aprender mientras juegan.

3.¿Qué oyen?

La interacción con otras personas es fundamental, ya que pueden escuchar a amigos suyos hablando de juegos emocionantes que han jugado hace poco. Además, no solo pueden oír de un vínculo cercano, sino también gracias a plataformas como Youtube y Twitch, donde la gente podría opinar de cualquier aspecto relacionado con el juego. Asimismo, debido a que el público del juego es joven, se podría dejar influenciar fácilmente por otras personas.

4.¿Qué dicen y hacen?

Entre las cosas que pueden decir se encuentra el hablar acerca de los logros o metas que han podido superar en el juego con sus amigos o familiares. Dentro de lo que pueden hacer podría encontrarse el descargar nuevos juegos en los diferentes dispositivos, ya sea móvil, PC, consola, etc. Y, además, jugar a diario para desafiar sus habilidades y desbloquear recompensas.

5.Esfuerzos

Los niños, al tener poca experiencia, necesitan de un gran esfuerzo para resolver rompecabezas o superar obstáculos en el juego que, a lo mejor, para una persona más mayor, no tendría problema ninguno en solventar. Además, invierten tiempo y energía en aprender y mejorar sus habilidades y, en caso de que para él le esté siendo muy difícil, buscan ayuda de amigos o familiares para enfrentar de forma más fácil el desafío.

6. Resultados

Como resultado experimentan un aumento en sus habilidades cognitivas y se sienten más confiados al superar nuevos desafíos para ellos. Además, mientras aprenden, disfrutan de una experiencia de juego divertida y educativa.

Ejemplo de mapa de empatía desde el punto de vista del padre del niño que juega el juego:

1.¿Qué piensan y sienten?

Los padres fundamentalmente piensan en la responsabilidad de supervisar las actividades en línea de sus hijos. Además, quieren que sus hijos tengan experiencias educativas de aprendizaje de calidad, pero, que a la vez sean divertidas para el niño.

2.¿Qué ven?

Con la influencia de las redes sociales, los padres podrían ver anuncios de juegos infantiles didácticos en redes sociales y sitios web.

A su vez, ven a otros padres discutiendo juegos y aplicaciones infantiles lo cual puede producir que, en un futuro no muy lejano, acaben comprando el producto.

3.¿Qué oyen?

La comunicación con otras personas es fundamental, ya que el padre del niño podría oír a otros padres o personas hablar de recomendaciones sobre juegos educativos y seguros. Además, muchas veces no tienes que irte muy lejos a preguntar a otras personas, sino que tu propio hijo te puede comentar acerca del videojuego al que le gustaría jugar.

4.¿Qué dicen y hacen?

Estos padres discuten con otros padres sobre qué juegos son apropiados y seguros y, de los cuales el niño podría sacar algún conocimiento del cual aprender. Del mismo modo, los padres podrían probar ellos mismos el juego antes de dárselo al niño para corroborar que puede ser un producto beneficioso para ellos y que no va a ser una mala influencia.

5.Esfuerzos

Dentro de los esfuerzos, los padres empeñan tiempo en encontrar juegos educativos y seguros que sean fructíferos y rentables para el niño. Además, dedican tiempo a investigar y leer reseñas sobre el juego en cuestión para ver que opina más gente.

6. Resultados

Como resultados, los padres ven como el hijo mejora sus habilidades y conocimientos a través del juego y, se sienten aliviados cuando ven a sus hijos disfrutar de un juego que es educativo y seguro.

## Caja de herramientas

El "Business Model Toolbox" o "Caja de Herramientas" es una herramienta que ayuda a las empresas a diseñar y visualizar sus modelos de negocio de manera más sencilla. La Caja de Herramientas incluye herramientas físicas o digitales, como tarjetas o imanes, que hacen más fácil trabajar con el "Canvas del modelo de negocio" en talleres y reuniones de planificación. En resumen, es una ayuda visual para pensar en cómo funciona un negocio y cómo mejorar su estrategia.

**Canvas del modelo de negocio**

Como modelo de negocio de nuestra empresa se ha escogido la fidelización. Tenemos como objetivo captar y conservar a nuestros clientes por varias razones. Queremos hacernos notar en una industria que es altamente competitiva. De esta forma, formando y construyendo nuestra propia comunidad de jugadores aseguramos ingresos recurrentes y feedback constante para la mejora de errores y posibles sugerencias para proyectos futuros.

Nos hemos centrado en una mezcla entre micro-transacciones y DLCs. Creemos que una de las maneras de obtener beneficios a través del juego es consiguiendo vender productos extra, como paquetes, niveles o skins adicionales, para todo aquel que quiera obtener todos los elementos del videojuego.


![Canvas de Modelo de Negocio Tabla para estrategia planeación negocio pastel moderno](https://github.com/tapeogames/Upstream/assets/145482203/82afc3c0-178a-461f-b504-936681237824)
