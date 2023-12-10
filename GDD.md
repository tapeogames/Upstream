# **UPSTREAM**

## **Tapeo Games**

| Nombre        | Mail          | Perfil GitHub  |
| :------------- |:-------------:| :------------- |
| Javier Álvarez Perez  | j.alvarezp.2020@alumnos.urjc.es | JavierAlper |
| Luna Bouzón Rodríguez    | l.bouzon.2020@alumnos.urjc.es | lunsbzn |
| Yeray Da Silva de las Heras    | y.da.2020@alumnos.urjc.es      |   yerayds |
| Javier de las Peñas Fernandez | j.delaspenas.2020@alumnos.urjc.es    |    Javieeh |
| Fabio Elías Rengifo García | fe.rengifo.2020@alumnos.urjc.e      |    faviolado |
| Lucas Rubio Lezana | l.rubiol.2020@alumnos.urjc.es      |    LucasWiggie |

<br>

## **Índice**

1. Introducción

2. Visión del Juego

3. Narrativa

4. Personajes

5. Mundo y Entorno

6. Arte y Gráficos

7. Música y Sonido

8. Interfaz de Usuario

9. Mecánicas de Juego

10. Diseño de Niveles

11. Controles

12. Tecnología y Plataforma

13. Análisis MDA

14. Modelo de Negocio

<br>

# INTRODUCCIÓN

El propósito del siguiente Game Design Document es proporcionar una visión general detallada de nuestro proyecto de videojuego, " **Upstream**". Este GDD servirá como hoja de ruta esencial para el desarrollo y diseño de nuestro juego, destacando la trama principal y las subtramas que darán vida a esta experiencia única.

**Upstream** es un videojuego 3D single-player para web que impulsa el pensamiento computacional en niños. El juego cuenta con diversos niveles a lo largo de los cuales el jugador será capaz de observar el desarrollo y crecimiento de Darwin, nuestro protagonista. Es un juego de tipo puzzle en el que el jugador deberá desplazarse por el escenario esquivando y desplazando obstáculos para llegar a una meta final, la cual representa el hogar de dichos anfibios.

<br>

# VISIÓN DEL JUEGO

El propósito central de " **Upstream**" es combinar la diversión y la educación de una manera cautivadora, utilizando un enfoque de juego que promueva el pensamiento computacional en niños. El juego está diseñado para involucrar a los jugadores en una experiencia emocionante mientras exploran conceptos clave de la programación y la resolución de problemas. A través de la historia de Darwin, el pequeño anfibio, los jugadores aprenderán sobre la importancia de la adaptación, la planificación estratégica y la superación de desafíos.

El objetivo principal del juego es guiar a Darwin a lo largo de su viaje de regreso a casa en el riachuelo. Cada nivel presenta un escenario lleno de obstáculos y desafíos que el jugador debe superar. Estos desafíos no solo son físicos, sino también cognitivos, ya que los jugadores deben idear estrategias para resolver problemas y tomar decisiones informadas para avanzar en el juego.

El juego tiene un tono generalmente optimista y educativo, que combina la emoción de una historia de supervivencia con elementos de descubrimiento y resolución de problemas. El juego trata temas como la adaptación, la evolución y la importancia de la naturaleza en nuestras vidas. El tono es amigable y accesible para niños, con un enfoque en la diversión y el entretenimiento, pero también en la educación.

El público objetivo principal de " **Upstream**" son niños y preadolescentes en edades comprendidas entre los 7 y los 12 años. Está diseñado específicamente para ser una herramienta educativa divertida que se integre en el aprendizaje informal. El juego se adapta a un nivel de habilidad y comprensión apropiado para esta franja de edad, lo que facilita que los niños puedan participar y disfrutar de la experiencia sin sentirse abrumados.

Además del público infantil, " **Upstream**" también puede atraer a padres, maestros y cuidadores interesados en ofrecer a los niños una experiencia de juego educativa y enriquecedora.

En un principio se plantearon los siguinetes Mood Boards:

![moodboard 1](https://github.com/tapeogames/Upstream/assets/145482203/0ca1c3ec-6fa9-45bd-858f-6ab5b239ae6e)
![moodboard 2](https://github.com/tapeogames/Upstream/assets/145482203/bf84fa6e-e8bc-4db2-8e33-fbd1da57dc9e)

<br>

# NARRATIVA

## Trama principal y subtramas

La narrativa central del juego trata sobre la aventura de un pequeño anfibio llamado Darwin durante el regreso con su familia. Esta especie de anfibios, similares a las salamandras, habita en las zonas altas de los riachuelos, donde depositan sus huevos y cuidan de sus crías en las aguas más tranquilas. Sin embargo, debido a un accidente, los padres de Darwin pierden el huevo de donde nacería él, no pudiendo evitar que la corriente se lo llevara río abajo. Darwin nace entonces en una pequeña cueva, alejado de su familia y de su especie, por lo que deberá explorar el mundo que le rodea y avanzar río arriba para volver a casa.

Acompañaremos a Darwin a lo largo de este viaje, donde deberá ingeniárselas para superar las dificultades del camino. Además veremos su crecimiento, ya que irá transitando por las diferentes fases de la metamorfosis, aprendiendo y ganando experiencia en su travesía.

También se cruzará con las diferentes criaturas con las que comparte ecosistema, de las cuales algunas serán obstáculos a evitar, mientras que otras necesitarán de su ayuda.

## Entornos

Los diversos escenarios del juego tendrán un papel narrativo que reflejará la perspectiva de Darwin sobre su situación a medida que crece y aprende .

Mientras es un renacuajo, se verá abrumado por la situación y se sentirá en un peligro constante. En consecuencia, los escenarios adoptarán un aspecto más sombrío y amenazante, con formas triangulares, colores fríos y una tenue iluminación. Estos representarán la cueva donde se estancó el huevo al ir río abajo.

En su siguiente fase, ya posee más experiencia y comenzará a ver las cosas de manera diferente, donde no todo son obstáculos de gran peligro. Los ambientes se iluminarán con colores más cálidos, evocando un amanecer, las formas serán más redondeadas, aunque se mantendrán elementos de la estética anterior. Darwin ha salido de la cueva y empieza a descubrir la naturaleza exterior del riachuelo.

Finalmente, al comienzo de su etapa adulta, Darwin ya tiene más conocimiento y percibe su entorno, peligros y dificultades de forma más realista. Por ello los escenarios adquirirán una apariencia más acogedora, con una iluminación diurna, colores más naturales y las formas amigables prevalecerán sobre las agresivas. Además empezará a encontrarse con elementos humanos a lo largo del río, indicando lo que ha avanzado en su viaje.

<br>

# PERSONAJES

El juego contiene un único personaje principal, Darwin, controlado por el usuario, aunque también se incluyen NPCs.

## Darwin

Como ya se ha mencionado en el apartado de narrativa, Darwin pertenece a una especie de anfibios que atraviesan un proceso de metamorfosis, similar al de las ranas y sapos. Comienzan su crecimiento como renacuajos y poco a poco evolucionan hasta convertirse en salamandras con patas y cola. Las consecuencias en el juego de este concepto se explican con más detalle en el apartado de mecánicas, ya que cada estado de la evolución de Darwin permitirá al jugador aplicar distintas mecánicas de juego en los niveles. El objetivo de este proceso evolutivo es ir acorde con la progresión de dificultad de los niveles. Se pretende mostrar a los niños una especie de metáfora de cómo uno debe adaptarse y mejorar a medida que vaya enfrentándose a nuevos retos, probando nuevas ideas o intentando resolver los problemas con formas de pensar distintas. Esto se verá representado en el juego por ejemplo cuando Darwin pase de ser un renacuajo a una salamandra con patas, por lo que el niño que esté jugando deberá alterar su visión de cómo resolver los puzles al tener en cuenta que ahora puede caminar por terreno firme y no solo nadar.

Pese a la cantidad de adversidades a las que se debe enfrentar, Darwin posee una personalidad relajada y alegre. Esto se puede apreciar en su constante sonrisa y naturaleza tranquila. Este diseño también posee un significado importante. Pese a que nuestro personaje se enfrenta a diferentes retos y situaciones difíciles, siempre se puede apreciar en su cara cómo sigue tranquilo e intenta resolver los puzles con calma. Esto, reforzado por la ambientación y los colores poco saturados o agobiantes, se ha hecho con el objetivo de que los niños se vean representados con Darwin. Que asimilen que, aunque uno se pueda enfrentar a situaciones complejas, deben mantener la serenidad y centrarse en hacerlo lo mejor que puedan, sin caer en la desesperación y entrar en pánico. De esta forma no solo se enseñan aptitudes de pensamiento computacional, sino que además se promueve el aprendizaje de estas con tranqulidad, paciencia y esfuerzo.

## NPCs

Pese a que el único personaje al que puede controlar el jugador es Darwin, se pretende incluir algunos NPCs que aparecerán en distintos niveles para ofrecer ayuda al jugador u obstaculizar su camino. Algunos de ejemplos son los siguientes:

- Patos:

En algunos niveles, una de las casillas estará ocupada por una mamá pato y otra, notablemente alejada de la anterior, por un patito. Se mostrará visiblemente cómo la mamá pato llora por no tener a su cría con ella, por lo que el jugador deberá conseguir llegar a la cría y arrastrarla o empujarla hasta la madre. Una vez los patos se hayan reunido, se recompensará al jugador, ya sea permitiéndole paso directamente a la salida del nivel o ayudándole con otra tarea.

**NPCs descartados**
- Sapos:

El jugador se encontrará con ellos en ciertos niveles en los que un sapo ocupará una casilla y estará croando, provocando vibraciones en el agua que no permitirán pasar a Darwin. Sin embargo, este obstáculo se puede sobrepasar si Darwin le lleva una mosca al sapo, el cual al empezar a comérsela, dejará de croar.

<br>

# MUNDO Y ENTORNO

La principal característica del entorno de juego es que este está diseñado para que el movimiento no sea libre, sino por cuadrículas. Esta decisión de diseño se debe a la naturaleza del juego, ya que como este está basado en puzzles, quisimos hacer que hubiese casillas de juego para que el usuario pueda resolverlos de forma más lógica para que pueda desarrollar de forma más efectiva su pensamiento computacional.

Los niveles tendrán su espacio de juego transitable y por otra parte, zonas por las que el jugador no podrá transitar. Siendo acorde a la narrativa, los primeros niveles a los que se enfrentará el jugador, correspondiente a su primera fase evolutiva, son dentro de una cueva oscura y sombría, donde la zona transitable sólo será el agua y los lugares por donde no podrá pasar serán rocas. Poco a poco se irán introduciendo distintos elementos que dan a entender que Darwin está saliendo al exterior, que es la siguiente fase del videojuego.

En la segunda fase se mezclarán elementos del exterior como plantas o troncos con rocas y zonas más oscuras, aunque como en la fase anterior, poco a poco se introducirán elementos que den pie a la siguiente fase. La zona transitable será el agua y las corrientes de agua que se irá encontrando.

En la última fase, Darwin ha salido al exterior y se encontrará con elementos tanto naturales como hechos por el hombre, como pueden ser botellas de plástico, neumáticos o barriles. La ambientación al ser en el exterior consta de colores más vibrantes y saturados. Además podra transitar tambíen por los tréboles estancados en el agua.

Durante las diversas fases el jugador se irá encontrando con NPCs cuyo diseño será acorde al espacio de juego del nivel, es decir, se podrá encontrar con aves en la tercera fase, desarrollada en el exterior, pero no en la primera ya que está en la cueva. Además, la complejidad de los escenarios y de sus puzzles se irá complicando a lo largo de los niveles, haciendo así que el jugador se enfrente a nuevos retos.

<br>

# ARTE Y GRÁFICOS

## Estilo visual y gráficos

"Upstream" es un videojuego de gráficos 3D que presenta una perspectiva isométrica con cámara fija. Su estilo visual persigue una estética estilizada de tipo "cartoon", con colores llanos y agradables, alejado de una visión realista y detallada. Esto se debe a que dicha estética se considera coherente para la clase de juego a desarrollar, ya que consigue simplificar los elementos que el usuario observa en los niveles, pudiendo analizar mejor los puzles y premeditar sus acciones sin distraerse con aspectos visuales excesivamente complejos e innecesarios. Además, al estar enfocada a niños de 3 a 12 años, permite llamar su atención a primera vista y retenerlos en el juego gracias al atractivo visual, sin caer en el error de diseñarlo con un estilo demasiado infantil.

En cuanto a la relevancia artística de los entornos, el juego estará dividido en niveles individuales donde, a medida que Darwin avance por el riachuelo, la ambientación cambiará adecuándose a este progreso. Además, como se ha explicado anteriormente, la atmósfera de los escenarios irá cambiando con el objetivo de transmitir los sentimientos y el punto de vista de Darwin durante su proceso de crecimiento.

## Arte conceptual

**Diseño Darwin Renacuajo** 
<br>
![Darwin Character Sheet Evo 1 REDISEÑO](https://github.com/tapeogames/Upstream/assets/81293638/d8c0cf99-65cc-43a8-9ec2-2b75b3d9cedd)
<br>
![Darwin Evo 1 - Turn Around](https://github.com/tapeogames/Upstream/assets/145482203/e6413e1a-47e4-4686-8069-42537256b5e3)

Darwin presenta un diseño basado en formas redondeadas, tanto circulares como triangulares, dando un aspecto amigable, inofensivo y dinámico. Su paleta de color cálida con tonos rosados afianza esa sensación de cercanía y simpatía. Al ser un renacuajo en esta primera fase, tiene una proporción del cuerpo de dos cabezas, mostrando su corta edad y entrando en un diseño más estilizado.

**Diseño Darwin Renacuajo Adulto** 
![Darwin Young Salamander ](https://github.com/tapeogames/Upstream/assets/82976203/f1fca6f0-653a-49db-8043-6080968a5ea9)

**Diseño Darwin Salamandra** 
![Darwin Salamander](https://github.com/tapeogames/Upstream/assets/82976203/6be0e778-ee44-44dd-bf50-ceb6683e70aa)

**Diseño Mamá Pato y Patito**
![Duck Mom TURN AROUND](https://github.com/tapeogames/Upstream/assets/82976203/8b7c3220-0bbe-42cc-a655-2c93ead20aa8)
![Duckling](https://github.com/tapeogames/Upstream/assets/82976203/28527900-4e1a-43c5-be0e-38cc1a2979c4)

**Diseño escenarios fase 1** 
<br>
![_Escenario1_Upstream](https://github.com/tapeogames/Upstream/assets/81293638/3d67b268-6114-4713-a5e4-862ad70d2a56)
![Escenario1Process](https://github.com/tapeogames/Upstream/assets/82976203/a6919dba-d5ab-47b7-b10d-25944c7a83f8)


Como se ha mencionado antes, los niveles de la primera fase se sitúan en una cueva, teniendo la apariencia de un entorno un tanto hostil. Para ello se utiliza una tenue iluminación para una ambientación más lúgubre acorde con la ubicación, y se hace uso de los contrastes tanto de forma, como de color y tamaño. De esta forma el escenario está compuesto de formas triangulares llenas de ángulos y una paleta monocromática fría, donde Darwin destaca por su forma redonda y color cálido, generando un ambiente más agresivo y oscuro, en el que encontramos a un Darwin solo e indefenso.

**Diseño escenarios fase 2** 

![EnvironmentSheetFase2](https://github.com/tapeogames/Upstream/assets/82976203/770b82f7-e674-4a99-96c1-9ed9dfc1b01b)
![ThumbnailsYValues](https://github.com/tapeogames/Upstream/assets/82976203/5400f654-0b20-4a6c-8b4a-b6b3b25c5584)

Los niveles de la fase 2 y 3 se ubican en el exterior del río, rodeado por la naturaleza. En la fase dos se busca un tono sentimental, nostálgico y de esperanza por la vuelta a casa, por lo que se hace uso de una iluminación de amanecer la cual da una paleta de cálidos en contraste con las sombras que genera. Además el entorno se vuelve menos hostil por lo que las formas angulosas desaparecen en su mayoría.
Por último, en la fase tres la iluminación se vuelve diurna dando más sensación de bienestar al entorno, Darwin ya es adulto, es más consciente de sus capacidades y cada vez está mas cerca de casa. También se incorporan algunos elementos humanos para dar sensación de próximidad a alguna zona poblada y de un mayor avance por el río. 

**Diseño Props**
![Peperomia](https://github.com/tapeogames/Upstream/assets/82976203/63b33f98-bbbc-4221-bf53-b02cf6e2af1f)
![Rocas](https://github.com/tapeogames/Upstream/assets/82976203/c2c7fb1a-30cf-4c8c-b116-2d8914e96987)
![Arbusto](https://github.com/tapeogames/Upstream/assets/82976203/fb5fd2fd-1e62-4319-9867-40696a40521d)
![nenufar](https://github.com/tapeogames/Upstream/assets/82976203/98a84152-b2f2-4149-b46b-ddeb07b50e42)
![moodboardHelecho](https://github.com/tapeogames/Upstream/assets/82976203/de8bfede-5b91-44f8-8385-f5a5d87681d4)
![moodboardMalanga](https://github.com/tapeogames/Upstream/assets/82976203/e00a44a1-2b35-428a-98aa-17f4518c0597)


<br>

# MÚSICA Y SONIDO

## Música

La música desempeña un papel vital en la experiencia de juego y la inmersión de los niños en nuestro juego de puzles. A continuación, se detallan las directrices relacionadas con la música:

- **Música Temática:** Se creará una música principal distintiva que se repetirá a lo largo del juego. Esta música debe ser alegre, amigable y estimulante para mantener la atención de los niños.

- **Variación de Pistas:** Además de la música principal, habrá pistas musicales específicas para momentos como la selección de niveles, logros y victorias en los puzles. Todas estas pistas seguirán el tono general del juego.

- **Instrumentos y Sonidos Amigables** : Los instrumentos y sonidos utilizados serán familiares y atractivos para los niños, como campanas, flautas, xilófonos.

- **Loops Continuos:** Todas las pistas de música se diseñarán como loops para garantizar una transición fluida y sin interrupciones durante el juego.

**Música provisional utilizada**

- **Niveles Fase 1:** https://pixabay.com/es/music/titulo-principal-cave-of-light-13566/

- **Niveles Fase 2:** https://pixabay.com/es/music/ambiente-a-fond-memory-116759/

- **Niveles Fase 3:** https://pixabay.com/es/music/pop-indie-in-the-forest-piano-version-175229/

## Efectos de Sonido

Los efectos de sonido son fundamentales para brindar retroalimentación y vida al mundo del juego. Aquí están las directrices para los efectos de sonido:

- **Interacción en el Juego:** Cada acción de los jugadores, como mover troncos en un escenario o interactuar con botones, generará efectos de sonido correspondientes. Esto mejora la interacción y la inmersión.

- **Efectos de Sonido Temáticos** : Los efectos de sonido serán amigables y acordes al estilo del juego, utilizando sonidos alegres y simpáticos.

- **Feedback Positivo:** Cuando los niños resuelvan niveles o alcancen logros, se utilizarán efectos de sonido que refuercen de manera positiva su éxito, como aplausos o una música alegre.

- **Feedback Negativo:** En caso de errores, se implementarán efectos de sonido suaves y amigables en lugar de sonidos severos o punitivos, con el objetivo de mantener un ambiente de juego positivo y de aprendizaje e instar a que vuelvan a intentarlo.

- **Ajustes de Volumen:** Se proporcionará la opción de ajustar el volumen de música y efectos de sonido en el menú de configuración del juego para garantizar la comodidad de los jugadores.

La música y los efectos de sonido serán diseñados específicamente para asegurar que contribuyan a una experiencia de juego divertida y apropiada para los niños, manteniendo un ambiente alegre y amigable en todo momento.

**Efectos provisionales utilizados**

- **Niveles Fase 1:** https://pixabay.com/es/sound-effects/relaxing-mountains-rivers-streams-running-water-18178/

- **Niveles Fase 2:** https://pixabay.com/es/sound-effects/nature-sounds-water-forest-crickets-calm-river-hq2496-chakongaudio-172342/

- **Niveles Fase 3:** https://pixabay.com/es/sound-effects/birds-singing-calm-river-nature-ambient-sound-127411/

- **Interfaces:** https://pixabay.com/es/sound-effects/nature-sounds-water-forest-crickets-calm-river-hq2496-chakongaudio-172342/

- **Botones:** https://pixabay.com/es/sound-effects/click-for-game-menu-131903/

<br>

# INTERFAZ DE USUARIO

Una interfaz en un juego, a menudo llamada "interfaz de usuario" o "UI", se refiere a todos los elementos visuales y gráficos que permiten a los jugadores interactuar con el juego y obtener información sobre su progreso, opciones y estado actual. La interfaz de usuario es una parte esencial de cualquier juego y desempeña un papel crucial por varias razones entre las que destacan la facilidad ante la comunicación, la inmersión que proporciona, el control y la navegación que provee, etc.

En el proceso de desarrollo de las interfaces de nuestro juego, hemos establecido un objetivo central: diseñar interfaces de usuario que sean intuitivas, fáciles de entender y simples de navegar. Reconocemos que nuestro público principal está compuesto por jugadores más jóvenes, y es esencial que disfruten de una experiencia de juego sin complicaciones desde el primer momento.

**Diagrama de flujo de Interfaces**

![Diagrama Flujo Upstream](https://github.com/tapeogames/Upstream/assets/81293638/af0232ee-dd3e-4339-afdb-e15979146692)


**Interfaz de la pantalla inicial**

Al abrir Upstream, la primera interacción que los jugadores encontrarán, después de una breve introducción con el logotipo de Tapeo Games, es una pantalla inicial en la que deberán proporcionar su edad y género. Esta información será utilizada con el objetivo de crear una base de datos y analizar las métricas y estadísticas de cada jugador. De esta forma, se podrá estudiar cuánto tiempo de media tarda cada uno en superar los niveles, la agilidad a la hora de navegar por los menús, etc. También se podrá analizar si efectivamente Upstream está ayudando a mejorar sus capacidades de pensamiento computacional, viendo su progreso entre niveles y observando su aprendizaje de mecánicas.

![Diagrama flujo 2](https://github.com/tapeogames/Upstream/assets/145482203/75511079-8eec-400d-86e3-68e05bf91a64)


**Interfaz del menú de inicio**

Después, los jugadores serán llevados al menú inicial, donde tendrán 4 botones con diferentes funciones. JUGAR les llevará a la pantalla de selección de niveles, donde podrán elegir qué nivel jugar (sólo se podrá jugar a un nivel si se ha superado previamente el anterior, excepto con el nivel 0). Si los usuarios prefieren configurar su experiencia antes de jugar, AJUSTES les llevará a un menú de ajustes donde podrán modificar diversos aspectos como el volumen o consultar los controles. CRÉDITOS les mostrará una pantalla donde se citará la autoría del juego y el equipo desarrollador, exhibiendo además cualquier otra contribución externa destacada. Finalmente, el botón SALIR cerrará el juego de manera rápida y sencilla.

![Diagrama flujo 3](https://github.com/tapeogames/Upstream/assets/145482203/7e0b108f-f7f9-4cd5-ba39-82a550de1bbf)


**Interfaz del selector de niveles**

En la interfaz del selector de niveles de Upstream, los jugadores encontrarán un menú donde podrán hacer clic en el nivel que deseen jugar. Este menú estará ambientado en el mundo del juego, con el escenario y los botones para elegir nivel mezclados artísticamente, similar a los mundos del conocido juego New Super Mario Bros.

Para seleccionar un nivel en particular, los jugadores simplemente deberán hacer clic en el icono correspondiente y serán llevados al mapa de dicho nivel, donde ya podrán jugarlo.

Referencia visual (New Super Mario Bros Wii):

![hq720](https://github.com/tapeogames/Upstream/assets/81293638/bd3e98ba-2a6c-4561-aa02-bbfab9f7b553)


**Interfaz del menú de pausa**

Una vez el usuario ha seleccionado el nivel que desea jugar, en este podrá pausar la partida. El menú de pausa mostrará a su vez 4 botones: REANUDAR para continuar jugando el nivel, AJUSTES para configurar aspectos como el volumen, CONTROLES para consultar los controles y SALIR para regresar a la pantalla de selección de niveles (perderá todo el progreso del nivel actual).

![Diagrama flujo 4](https://github.com/tapeogames/Upstream/assets/145482203/479d44f0-3eab-40f8-9473-2c9cd0c4315a)



**Interfaz del menú de victoria**

En el menú de victoria se encontrarán dos botones fundamentales que te permitirán decidir cómo proceder después de completar un nivel. El primer botón, SIGUIENTE NIVEL, te llevará al próximo nivel en la secuencia de la historia del juego. Si en cambio prefieres volver al punto de inicio o explorar otras opciones disponibles en el jeugo, el segundo botón, MENÚ PRINCIPAL, te llevará de vuelta al menú principal del juego.

![Diagrama flujo 5](https://github.com/tapeogames/Upstream/assets/145482203/e05b4985-5e65-44a7-a1fa-7c8b0de9320d)

<br>

# MECÁNICAS DE JUEGO

A lo largo del juego, se irán presentando diferentes mecánicas de progresión para incrementar la dificultad de los niveles y presentar un reto al jugador, que deberá saber cómo aplicarlas para poder avanzar.

La mecánica principal es el movimiento del personaje. El jugador podrá moverse en las 4 direcciones cardinales utilizando los respectivos controles con las teclas ASDW y avanzará de casilla en casilla (las casillas no serán visibles pero el usuario podrá observar cómo Darwin se mueve en unidades y no de forma continua). El diseño de niveles se ha realizado de forma que esta mecánica sea esencial para poder avanzar en el juego, ya que el objetivo principal en cada nivel es llegar a la salida.

Sin embargo, pese a que Darwin podrá moverse con cierta libertad por los niveles, en ellos se encontrará con numerosos obstáculos. El usuario podrá interactuar con algunos de ellos gracias a la mecánica de agarrar/empujar, la cual permite mover dichos obstáculos a otras casillas para abrirse paso hacia la salida. Este concepto se mantendrá a lo largo de todo el juego pero se explotará de numerosas formas para aumentar la complejidad, obligar al jugador a planificar más sus acciones y diversificar los puzles.

Los obstáculos se dividen en dos categorías principales: movibles e inamovibles. 
- **Movibles**: Darwin no puede atravesarlos, pero sí agarrarlos o empujarlos. Estas acciones no se pueden realizar lateralmente, es decir, cuando Darwin coge el objeto movible (por ejemplo una rama), sólo se podrá mover hacia delante o hacia atrás con ella. 
- **Inamovibles**: Darwin no puede empujarlos ni agarrarlos. Sirven como obstáculo dentro del mapa, colocados estratégicamente para aumentar la complejidad del nivel. Pueden ser de tres tipos: *no atravesables* (Darwin no puede pasar a través de ellos), *atravesables* (Darwin, si no está agarrando o empujando un objeto, puede pasar a través de ellos) o *atravesables con objeto* (Darwin puede pasar a través de ellos, ya sea él sólo o sujetando un objeto).

A continuación, se muestra una tabla con algunos ejemplos de obstáculos y su respectiva categorización:

| Obstáculo              |         Categoría         | Observaciones                                                                                                                                                                                                                                                     |
|:-----------------------|:-------------------------:|:------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Roca/Rueda             | inamovible no atravesable | El aspecto de rueda se utilizará en los niveles de la fase 3                                                                                                                                                                                                      |
| Arena/Tréboles         |  inamovible atravesable   | No atravesable con Darwin renacuajo o renacuajo adulto, los troncos pueden empujarse sobre ellos y hacia fuera, pero no se pueden volver a meter. Finalmente su aspecto es de tréboles con flores                                                                                                                                                                                                            |
| Estalagmitas/Nenúfares |  inamovible atravesable   | El aspecto de nenúfar se utilizará en los niveles de la fase 2 y 3                                                                                                                                                                                                |
| Rama/Tronco/Botella    |          movible          | El aspecto de botella se utilizará en los niveles de la fase 3                                                                                                                                                                                                    |
| Corriente              |  inamovible atravesable   | Las corrientes son sólo en una dirección. Al posicionar un objeto o a Darwin en la corriente será impulsado hasta el final de esta. Si se intenta ir a contracorriente, o el final de esta está bloqueado el obstáculo se convertirá en inamovible no atravesable |
| Remolino               |  inamovible atravesable   | Sirven como portales por los que se pueden mandar objetos o usar de paso. Estos se bloquean si sus posiciones contiguas, a las que mandan los objetos, están ocupadas.                                                                                            |
| Patito                 |          movible          | Patito sí puede atravesar los objetos atravesables junto con Darwin.                                                                                                                                                                                              |
| Mamá Pato              | inamovible no atravesable | Mamá Pato bloqueará el paso a Darwin, cuando Patito este en una de sus posiciones contiguas, este se subirá encima suya y abrirán el paso.                                                                                                                        |
<br>

**Pull Mechanic**
![Pull Concept](https://github.com/tapeogames/Upstream/assets/81293638/3ac35bd4-af46-410e-bb50-9d31c5cb4c65)

<br>

**Push Mechanic**
![Push Concept](https://github.com/tapeogames/Upstream/assets/81293638/8010077f-74cd-469f-a954-754153d940f3)


El personaje contará con un sistema de progresión de mecánicas que irá relacionado con la etapa evolutiva en la que se encuentra el personaje, estas serán tres:

- **Renacuajo**: en esta etapa Darwin solo podrá ir por el agua ya que sus patas son demasiado pequeñas como para abrirse paso por la vegetanción estancada, también podrá tirar y empujar de las ramitas que se encuentre como obstáculos.

- **Renacuajo adulto**: durante esta etapa el personaje se encontrará con troncos que podrá mover y con corrientes que podra utilizar para desplazarse y mover objetos.

- **Salamandra**: en esta etapa Darwin habrá alcanzado su estado de evolución completo por lo que podrá moverse y arrastrar objetos también por encima de los tréboles estancados en el agua, se enontrará con otros animales y utilizará remolinos para teletransportarse.

En cuanto a los controles del juego, para ordenador, se podrá mover a Darwin con WASD y para interactuar con un objeto y arrastrarlo, habrá que pulsar y mantener el espacio. Para móvil se implementarán cuatro botones para el movimiento y uno para la interacción con objetos.

<br>

# DISEÑO DE NIVELES

Los niveles están distribuidos se basan en la resolución de puzles por medio de las diferentes mecánicas que se han expuesto y acorde con la fase de la metamorfosis de Darwin. Estos serán 12 niveles, cuatro por cada una de las etapas ya mencionadas y tendrán una duración de entre 3-5 minutos de media.

### Fase 1

**Diseño de nivel 0**
![Nivel0](https://github.com/tapeogames/Upstream/assets/115087211/9117f769-9241-4c82-8933-d8b126285400)

El nivel inicial está diseñado como primer contacto del jugador con los puzzles y mecánicas del juego, la razón por la cual su complejidad es sencilla. Se busca que el usuario conozca dos elementos, las ramas, del cual se podrá empujar y tirar, y los nenúfares/piedritas, por las que Darwin puede pasar, pero los troncos no.

**Diseño de nivel 1**
![Nivel1](https://github.com/tapeogames/Upstream/assets/115087211/18e9d8ed-f3dd-4f1f-8e15-4a0f87138466)

Este siguiente nivel aumenta en complejidad e introduce al jugador en una situación más común de la resolución de puzles, la contradicción y el conflicto. El usuario tendrá que pensar el orden de sus acciones para que no supongan un obstáculo más a la hora de encontrar la solución. Además se introduce la arena/suelo para enseñar que no se puede pasar a través de ella, aunque en un futuro cuando Darwin haya crecido sí serán zonas transitables.

**Diseño de nivel 2**
![nivel2](https://github.com/tapeogames/Upstream/assets/82976203/2502b561-e412-4eda-bc33-881ca064d59b)

**Diseño de nivel 3**
![nivel3](https://github.com/tapeogames/Upstream/assets/82976203/0962d760-dfea-4594-8ad8-74d8ef58b23b)

### Fase 2

**Diseño de nivel 4**
![nivel4](https://github.com/tapeogames/Upstream/assets/82976203/e2b0df6f-40eb-4cf7-9a65-0b3627351132)

En este nivel se enseña al jugador por primera vez la mecánica de la corriente.

**Diseño de nivel 5**
![nivel5](https://github.com/tapeogames/Upstream/assets/82976203/4c0f10ca-fac0-441b-be1f-54cb18986ecd)

A causa de que el jugador podría llegar a quedarse atascado en el nivel sin poder llegar a la solución, este tuvo que rediseñarse.

![nivel5Rediseño](https://github.com/tapeogames/Upstream/assets/82976203/e666095b-9fa9-48a5-89e8-417a493fc67d)

**Diseño de nivel 6**
![nivel6](https://github.com/tapeogames/Upstream/assets/82976203/4f7fd3d3-0978-45eb-bfb1-9af3bdb9cf24)

A causa de que el jugador podría llegar a quedarse atascado en el nivel sin poder llegar a la solución, este tuvo que rediseñarse.

![nivel6Rediseño](https://github.com/tapeogames/Upstream/assets/82976203/8dbef63c-58bb-424b-9d2f-14da2049f994)

**Diseño de nivel 7**
![nivel7](https://github.com/tapeogames/Upstream/assets/82976203/8488f407-d7d9-48dc-92a0-506f4e8d862b)

Este nivel se utiliza para mostrar al jugador como funciona la Mamá Pato y Patito para que lo tenga en cuenta a la hora de resolver el nivel.

**Diseño de nivel 8**
![nivel8](https://github.com/tapeogames/Upstream/assets/82976203/5490ed4c-3be2-4e19-a4f4-2fce7a74b51d)

Se mezclan las mecánicas de la corriente y los patos.
A causa de que el jugador podría llegar a quedarse atascado en el nivel sin poder llegar a la solución, este tuvo que rediseñarse.

![Nivel8Rediseño](https://github.com/tapeogames/Upstream/assets/82976203/cdf1e393-b42d-48b1-a743-caa23a63398d)

### Fase 3

**Diseño de nivel 9**
![nivel9](https://github.com/tapeogames/Upstream/assets/82976203/2e550388-0703-43a3-83cd-6522fd53fa97)

Introducción de la arena ahora siendo posible camniar por ella.

**Diseño de nivel 10**
![nivel10](https://github.com/tapeogames/Upstream/assets/82976203/64070132-0fb8-4f96-9a86-3d58a6e69930)

Introducción de la función de los remolinos.

**Diseño de nivel 11**
![nivel11](https://github.com/tapeogames/Upstream/assets/82976203/00e16bdc-a588-4638-b507-49b532455993)

Se mezclan el uso de los remolinos, la corriente y la arena.
A causa de que el jugador podría llegar a quedarse atascado en el nivel sin poder llegar a la solución, este tuvo que rediseñarse.

![nivel11Rediseño](https://github.com/tapeogames/Upstream/assets/82976203/87982dfb-a762-4c5b-9eec-d173943b0d53)

**Diseño de nivel 12**
![nivel12](https://github.com/tapeogames/Upstream/assets/82976203/2a64ed2f-9d05-4ae9-8852-249f344e9027)

Unión de los elementos de la arena y los patos.

**Diseño de nivel 13**
![nivel13](https://github.com/tapeogames/Upstream/assets/82976203/6ddcf7b6-04ba-4b2f-9ffa-9d53e7fbfd0b)

Se une la mecánica de los remolinos junto con la arena y los patos.

**Diseño de niveles desechados**
![nivel12Rana](https://github.com/tapeogames/Upstream/assets/82976203/dd0efc0c-563d-499b-8767-f7799cfb7a90)
![nivel13Rana](https://github.com/tapeogames/Upstream/assets/82976203/bb2d93cd-abd9-46e5-89f7-e32ea1191b63)

Los niveles 12 y 13 tuvieron que ser rediseñados a causa de la falta de implementación de la mecánica de la Rana y la mosca debido a una falta de tiempo.
<br>

# PENSAMIENTO COMPUTACIONAL

Upstream incorpora puzles diseñados para promover y desarrollar habilidades de pensamiento computacional, cuyos enfoque reside en la resolución de problemas y busca, no solo entretener, sino también cultivar habilidades fundamentales que pueden servir a los usuarios a desarrollar ciertas competencias útiles en la era digital en la que nos encontramos.

El pensamiento computacional, comprende una serie de competencias que trascienden la programación y la tecnología, y que son aplicables en situaciones cotidianas. Upstream se presenta como una herramienta efectiva para el fomento de este tipo de pensamiento al desafiar a los jugadores con una serie de puzles.

Una de las características primordiales del pensamiento computacional que Upstream refuerza es la abstracción. El usuario se enfrenta a situaciones que demandan la identificación de patrones o conexiones entre elementos en el juego. Este proceso implica la habilidad de simplificar problemas complejos, una competencia esencial para la toma de decisiones en la vida diaria. Un ejemplo de esta característica que está implementado en Upstream es el reconocimiento de que objetos pueden resultar útiles al usuario o no, por ejemplo, los objetos que puede empujar y arrastrar (que son aquellos que se encuentran flotando en el agua en el caso de la primera etapa) y por los que no puede pasar, o aquellos por los que puede pasar pero no puede atravesarlo ningún otro objeto. Es decir, buscamos que el usuario reconozca elementos clave para poder resolver los puzzles a los que se enfrenta.

La descomposición es otro pilar que se fortalece a medida que los jugadores abordan los puzles de Upstream. El juego plantea desafíos que con frecuencia requieren la descomposición de un problema en componentes más pequeños y manejables. Este enfoque en la resolución de problemas es una competencia fundamental en la informática y también en la vida en general, dado que permite enfrentar problemas complejos de manera sistemática y ordenada.  Por ejemplo, para poder pasar al final del nivel, el jugador necesitará ir quitando obstáculos y situandolos en otras zonas, siempre buscando no entorpecer el camino hasta otra zona donde puede haber elementos que resulten útiles al jugador posteriormente.

La generalización constituye el tercer elemento central del pensamiento computacional que Upstream busca promover. A lo largo del juego, los jugadores se encuentran con diversos desafíos, cada uno con sus propias reglas y dinámicas. Con el avance en el juego, se espera que generalicen principios y estrategias previamente adquiridos para su aplicación efectiva en nuevos contextos. Esta capacidad de extrapolar conocimiento es de gran utilidad tanto en la programación como en la toma de decisiones cotidianas, donde se afrontan situaciones inesperadas. Aunque en Upstream existe una curva de dificultad progresiva, se ha buscado diseñar los niveles para que el usuario sea capaz de reconocer ciertas situaciones y que una vez que haya superado unos cuantos niveles, sepa reconocer peligros, ayudas y atajos para poder llegar a la casilla final, este sería el caso de corrientes, obstáculos, personajes o teletransportes.

En resumen, Upstream trasciende del entretenimiento y busca posicionarse como una herramienta educativa de vanguardia que promueve habilidades de pensamiento computacional. A través de la aplicación de conceptos como la abstracción, la descomposición y la generalización, el juego busca desafiar a los jugadores para que estos adquieran destrezas fundamentales para afrontar problemas de la era digital, y de la propia vida cotidiana.

<br>

# CONTROLES

" **Upstream**" cuenta con interfaces navegables con cursor y teclado, con un click se podrá acceder a la ruta querida. En la próxima entrega del juego está previsto meter la navegabilidad en el móvil, haciendo que con pulsar una vez se entre en el lugar querido.

Actualmente, como no contamos con una implementación final, los controles básicos del personaje serán los siguientes:

![wasd](https://github.com/tapeogames/Upstream/assets/145482203/67a7b706-e7da-4c12-944e-9fad2ede1a90)


Este será para el movimiento en el mundo virtual en el eje xz. En este caso, **A** será izquierda; **D** , derecha; **W** , arriba y **S** , abajo. Además, el personaje tendrá la posibilidad de empujar algunos objetos interactuables con la tecla **ESPACIO** , y este objeto se moverá en dirección en la que mire el personaje y se pulse la tecla. Además, si se mantiene pulsada la misma tecla, también habrá la posibilidad de arrastrar hacia el sentido trasero del personaje. Esto será inicialmente así en ordenador, pero está previsto añadir también controles para móviles, que aún están por determinar.

<br>

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

<br>

# ANÁLISIS MDA

## Estéticas

### Desafío:

En Upstream, es sobre todo el desafío lo que define la experiencia del jugador. Los puzles de cada nivel se presentan como un reto progresivo donde se van añadiendo nuevos elementos, su resolución no solo es determinante para poder avanzar en el juego, sino que también ofrece una satisfacción intrínseca al superar cada obstáculo. Al ser esto el motor de la progresión, aumenta el sentimiento de reto y superación tratando de mantener la motivación del jugador.

### Sensación:

La estética de la sensación se basa tanto en el apartado visual de cada nivel como en la narrativa y la propia jugabilidad.
El desafío que presentan los niveles busca provocar que el jugador pueda sentirse abrumado por estos como realizado al encontrar una solución.
Por otro lado, la narrativa y la ambientación complementan esta estética al tratar de involucrar emocionalmente al jugador al ver y empatizar con Darwin a medida que avanza por los diferentes tramos de su viaje.

### Fantasía:

La elección de un estilo cartoon en Upstream transporta al jugador a una fantasía encantadora donde asume el papel de un ajolote en su vuelta a casa a través de un río repleto de desafíos a resolver.

### Narrativa:

Upstream cuenta con una base narrativa que no solo proporciona contexto a la situación inicial del juego, sino que también da una motivación al viaje de Darwin e incita al jugador a avanzar en el juego al verse más conectado con este.

## Dinámicas

### Desafío y Variedad:

Las dinámicas del juego buscan presentar desafíos diversos en cada nivel donde el jugador se sienta retado. La variedad de elementos y personajes que obstaculizan el progreso no solo añade complejidad, sino que también fomenta la adaptación continua de estrategias por parte del jugador.

### Libertad y Flexibilidad:

La capacidad de movimiento en los niveles no solo es un medio para avanzar, sino una herramienta estratégica. La interacción con elementos, como los troncos o las corrientes, ofrece a los jugadores la libertad de explorar diferentes enfoques y estrategias donde también cabe la posibilidad de complicar los niveles por malos planteamientos, lo que fomenta una reflexión constante y una mejora continua. Esta flexibilidad agrega profundidad a la experiencia de juego, fomentando la experimentación y el descubrimiento con el objetivo de superar el nivel.

### Progresión y Reto Continuo:
La progresión del juego y el desafío continuo están intrínsecamente conectados. La imposibilidad de avanzar sin superar los niveles anteriores crea una motivación persistente para los jugadores. Cada nivel completado se convierte en un hito significativo, reforzando la sensación de logro y fomentando la determinación para abordar desafíos más complejos.

## Mecánicas

Las mecánicas del juego se centran en elementos del entorno, como troncos, corrientes y remolinos que se interpondrán entre el jugador y la casilla de salida, solo hay una por nivel y se tendrá que alcanzar para superar este con éxito. Cada uno de los elementos presenta comportamientos diferentes que obstaculizan o ayudan en la resolución de los puzles. La comprensión de cómo hacer uso de estos elementos, ya sea de manera individual o en combinación, se convierte en la clave para avanzar de manera efectiva.

<br>

# MODELO DE NEGOCIO

## Información de usuario

El usuario, o persona que jugará a Upstream, será una persona con edad comprendida entre 5 y 12 años. Es un niño que tiene cuenta con dos padres y un hermano de las mismas edades. Mantiene una buena relación con ellos y con todo su entorno. Es bastante competitivo, tanto que le gusta ver con sus amigos quién es mejor en videojuegos. Es una persona con bastante interacción social, ya que tiene tanto actividades escolares como extraescolares. Está un poco aburrido de hacer lo mismo de siempre, fútbol, baloncesto… Le gusta todo lo relacionado con los ordenadores. Por ello, quiere alguna actividad que de verdad le entretenga y le divierta.

## Mapa de empatía

Un mapa de empatía en modelos de negocio es una herramienta visual que ayuda a comprender mejor a los clientes o usuarios de un producto o servicio. Esta herramienta se utiliza en el proceso de diseño de negocios para desarrollar una comprensión más profunda de las necesidades, deseos, motivaciones y frustraciones de los clientes. El objetivo es ponerse en el lugar del cliente para poder crear productos o servicios que realmente satisfagan sus necesidades y expectativas.

<br>

Ejemplo de mapa de empatía desde el punto de vista de un niño que juega al juego:

**1.¿Qué piensan y sienten?**

Los niños a estas edades (Aprox 6-10 años) piensan, fundamentalmente, en divertirse mientras juegan, quieren sentirse desafiados mientras logran éxito a medida que va avanzando el juego.

Además, cabe destacar que se sienten emocionados cuando encuentran personajes o mundos llamativos para ellos.

**2.¿Qué ven?**

Debido a la gran evolución y expansión de los videojuegos, a día de hoy, cualquier persona puede jugar a juegos, independientemente de la edad que pueda tener el cliente. Asimismo, lo que el niño ve son anuncios de juegos en línea y en la televisión, ven también a amigos y compañeros de clase jugando videojuegos o, también, ven a sus padres y maestros animándolos a aprender mientras juegan.

**3.¿Qué oyen?**

La interacción con otras personas es fundamental, ya que pueden escuchar a amigos suyos hablando de juegos emocionantes que han jugado hace poco. Además, no solo pueden oír de un vínculo cercano, sino también gracias a plataformas como Youtube y Twitch, donde la gente podría opinar de cualquier aspecto relacionado con el juego. Asimismo, debido a que el público del juego es joven, se podría dejar influenciar fácilmente por otras personas.

**4.¿Qué dicen y hacen?**

Entre las cosas que pueden decir se encuentra el hablar acerca de los logros o metas que han podido superar en el juego con sus amigos o familiares. Dentro de lo que pueden hacer podría encontrarse el descargar nuevos juegos en los diferentes dispositivos, ya sea móvil, PC, consola, etc. Y, además, jugar a diario para desafiar sus habilidades y desbloquear recompensas.

**5.Esfuerzos**

Los niños, al tener poca experiencia, necesitan de un gran esfuerzo para resolver rompecabezas o superar obstáculos en el juego que, a lo mejor, para una persona más mayor, no tendría problema ninguno en solventar. Además, invierten tiempo y energía en aprender y mejorar sus habilidades y, en caso de que para él le esté siendo muy difícil, buscan ayuda de amigos o familiares para enfrentar de forma más fácil el desafío.

**6. Resultados**

Como resultado experimentan un aumento en sus habilidades cognitivas y se sienten más confiados al superar nuevos desafíos para ellos. Además, mientras aprenden, disfrutan de una experiencia de juego divertida y educativa.

<br>

Ejemplo de mapa de empatía desde el punto de vista del padre del niño que juega el juego:

**1.¿Qué piensan y sienten?**

Los padres fundamentalmente piensan en la responsabilidad de supervisar las actividades en línea de sus hijos. Además, quieren que sus hijos tengan experiencias educativas de aprendizaje de calidad, pero, que a la vez sean divertidas para el niño.

**2.¿Qué ven?**

Con la influencia de las redes sociales, los padres podrían ver anuncios de juegos infantiles didácticos en redes sociales y sitios web.

A su vez, ven a otros padres discutiendo juegos y aplicaciones infantiles lo cual puede producir que, en un futuro no muy lejano, acaben comprando el producto.

**3.¿Qué oyen?**

La comunicación con otras personas es fundamental, ya que el padre del niño podría oír a otros padres o personas hablar de recomendaciones sobre juegos educativos y seguros. Además, muchas veces no tienes que irte muy lejos a preguntar a otras personas, sino que tu propio hijo te puede comentar acerca del videojuego al que le gustaría jugar.

**4.¿Qué dicen y hacen?**

Estos padres discuten con otros padres sobre qué juegos son apropiados y seguros y, de los cuales el niño podría sacar algún conocimiento del cual aprender. Del mismo modo, los padres podrían probar ellos mismos el juego antes de dárselo al niño para corroborar que puede ser un producto beneficioso para ellos y que no va a ser una mala influencia.

**5.Esfuerzos**

Dentro de los esfuerzos, los padres empeñan tiempo en encontrar juegos educativos y seguros que sean fructíferos y rentables para el niño. Además, dedican tiempo a investigar y leer reseñas sobre el juego en cuestión para ver que opina más gente.

**6. Resultados**

Como resultados, los padres ven como el hijo mejora sus habilidades y conocimientos a través del juego y, se sienten aliviados cuando ven a sus hijos disfrutar de un juego que es educativo y seguro.

<br>

## Caja de herramientas

El “Business Model Toolbox” o “Caja de Herramientas” es una herramienta que ayuda a las empresas a diseñar y visualizar sus modelos de negocio de manera más sencilla. La Caja de Herramientas incluye herramientas físicas o digitales, como tarjetas o imanes, que hacen más fácil trabajar con el “Canvas del modelo de negocio” en talleres y reuniones de planificación. En resumen, es una ayuda visual para pensar en cómo funciona un negocio y cómo mejorar su estrategia.

![caja herramientas](https://github.com/tapeogames/Upstream/assets/115087211/f4a07c49-925c-4cbb-9b31-1fa7078463a5)

Inicialmente, nuestra caja de herramientas establece una relación directa con nuestros compradores, ya que ellos aportan recursos financieros a cambio de una copia de nuestro juego.

Por otro lado, mantenemos colaboraciones con otras empresas, especialmente en el proceso de distribución. Estas empresas proporcionan visibilidad en el mercado y servicios técnicos, como servidores que nos permiten crear clasificaciones mundiales basadas en el tiempo que los jugadores invierten en cada nivel. Además, estas plataformas de distribución nos brindan datos clave, como las descargas del juego, la cantidad de jugadores en un momento específico, el punto máximo de usuarios simultáneos, así como reseñas de los usuarios. Esta colaboración se sustenta en un acuerdo mutuo donde estas empresas reciben una parte de los beneficios que generamos.

Con respecto a los centros educativos, nuestra relación gira en torno a la venta de nuestro producto, a la vez que nos proveen información valiosa sobre el progreso de los alumnos. Esto nos permite evaluar el valor educativo de nuestro juego.

Por último, identificamos dos posibles fuentes de financiamiento. En un escenario, el gobierno podría respaldar nuestro proyecto a través de concursos centrados en propuestas educativas, donde el ganador recibe un financiamiento significativo para llevar a cabo su idea. Por otro lado, existe la posibilidad de que una empresa nos contrate para desarrollar nuestra idea, otorgándonos financiamiento a lo largo de la duración del proyecto. En este último caso, la empresa que nos contrata obtendría derechos sobre el proyecto y proporcionaría recursos y experiencia.


## Canvas del modelo de negocio

Como modelo de negocio de nuestra empresa se ha escogido la fidelización. Tenemos como objetivo captar y conservar a nuestros clientes por varias razones. Queremos hacernos notar en una industria que es altamente competitiva. De esta forma, formando y construyendo nuestra propia comunidad de jugadores aseguramos ingresos recurrentes y feedback constante para la mejora de errores y posibles sugerencias para proyectos futuros.

Nos hemos centrado en una mezcla entre micro-transacciones y DLCs. Creemos que una de las maneras de obtener beneficios a través del juego es consiguiendo vender productos extra, como paquetes, niveles o skins adicionales, para todo aquel que quiera obtener todos los elementos del videojuego.


![Canvas de Modelo de Negocio Tabla para estrategia planeación negocio pastel moderno](https://github.com/tapeogames/Upstream/assets/145482203/82afc3c0-178a-461f-b504-936681237824)
