# AgregarOEliminarElementos

- **_Este es un tutorial interesante; Le mostraremos cómo agregar rectángulos a la ubicación donde hace clic con el mouse y cuando haga clic en los rectángulos, los eliminará de la aplicación._**
- **_Esta técnica será muy útil para el desarrollo de juegos, ya que podemos agregar o eliminar dinámicamente objetos de la pantalla según sea necesario._**
- **_Estamos utilizando Microsoft Visual Studio 2017 para crear esta aplicación que puede seguir junto con cualquier versión que admita la aplicación de formulario WPF._**

### Objetivos de este proyecto:

  - **_Crear una aplicación que agrega y elimina todos los cuadriláteros de la escena._**
  - **_Crear eventos de clic del mouse para trabajar con el elemento del lienzo en WPF._**
  - **_Capturar la ubicación del click del mouse y agregue cuadriláteros a esa ubicación._**
  - **_Capturar los clicks del mouse a los cuadriláteros y eliminar el cuadrilátero en el que se hizo click._**
  - **_Agregar colores aleatorios a los cuadriláteros para que los reconozca en el sistema._**

### Tutoriales escritos y código fuente a continuación:

- **_Abra Visual Studio e inicie un nuevo proyecto._**

  ![image](https://github.com/MARSFOREVER472/AgregarOEliminarElementos/assets/69094327/7226c288-8115-4531-a695-92c2334f766a)

- **_Nómbrelo Agregar y quitar elementos dinámicamente y haga clic en Aceptar._**
- **_Asegúrese de guardar este archivo de proyecto en una ubicación donde pueda encontrarlo nuevamente._**

  ![image](https://github.com/MARSFOREVER472/AgregarOEliminarElementos/assets/69094327/9803c6b5-ed27-494a-bf2f-f55cda46544e)

- Esta es la vista predeterminada del proyecto hasta el momento. Haremos algunos cambios en la parte inferior del código aquí.

  ![image](https://github.com/MARSFOREVER472/AgregarOEliminarElementos/assets/69094327/09a4e2fb-46a4-4f9e-94f9-ca58c403188f)

- Agregue la parte resaltada al título de la aplicación, esto activará el administrador de enfoque y mantendrá el lienzo principal enfocado mientras se ejecuta la aplicación.

  ![image](https://github.com/MARSFOREVER472/AgregarOEliminarElementos/assets/69094327/e7303699-a388-408f-8543-087f3b304d22)

- Necesitamos eliminar esta cuadrícula y agregar lienzo aquí.

  ![image](https://github.com/MARSFOREVER472/AgregarOEliminarElementos/assets/69094327/3b453576-6168-47d3-8985-51337bccdf4a)

- Este lienzo que agregamos tiene sus propias propiedades dentro de él. Primero le dimos un nombre para poder interactuar con él desde el script C#, también configuramos el enfoque enfocable en verdadero.
- Este lienzo tiene un evento con el botón izquierdo del mouse llamado addRemoveItems y tiene un color de fondo blanco.
- El evento agregar y/o eliminar elementos se utilizará para verificar dónde hicimos clic en el lienzo y dónde agregar los elementos.
- Por ahora esto es todo lo que necesitamos para este lienzo. Ahora podemos comenzar a agregar códigos C# para este proyecto.
- Haga clic derecho en la palabra clave addRemoveItems y haga clic en Ir a definición.

  ![image](https://github.com/MARSFOREVER472/AgregarOEliminarElementos/assets/69094327/fdfa76bd-bbde-4bee-890e-d3f16d559893)

- Esto nos llevará a la página del script C# y agregará la definición automáticamente.
- Puedes escribirlo manualmente pero de esta manera es más rápido.

  ![image](https://github.com/MARSFOREVER472/AgregarOEliminarElementos/assets/69094327/93076557-b839-4d4b-adeb-1b79294c6dd5)

- Este es el script C# para esta aplicación hasta ahora, necesitaremos agregar un par de variables aquí y luego podremos comenzar con el evento.

  ![image](https://github.com/MARSFOREVER472/AgregarOEliminarElementos/assets/69094327/c7c8f624-9e9e-4564-92df-95da9fc15d54)

- Agregue las dos líneas siguientes encima de la función de la ventana principal.
- Estas dos líneas representan dos variables que necesitaremos para esta aplicación.
- El primer Brush Custombrush es una variable Brush que nos permitirá crear nuevos colores para los cuadros.
- Queremos que cada cuadro sea diferente al anterior, por lo que debemos convertirlo en un color aleatorio para poder generar colores aleatorios, necesitamos la segunda línea.
- Random r = new Random() ayudará a crear números aleatorios entre dos valores.

- Programemos el evento agregar eliminar elementos ahora y veamos qué hace.
  
Aquí está la lógica detrás del evento:

```
Primero comprobamos si hacemos clic en un rectángulo existente.

IF so

Identifica este rectángulo

Eliminar el rectángulo identificado de la pantalla

IF NOT (ELSE)

Crea un nuevo rectángulo (aplica tamaño, color aleatorio, borde, etc.)

Establezca la posición del rectángulo en la ubicación del clic (X e Y)

Agrega el rectángulo a la pantalla.
```

Kind regards!

***MARSFOREVER472***
