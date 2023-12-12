# AgregarOEliminarElementos

- Este es un tutorial interesante; Le mostraremos cómo agregar rectángulos a la ubicación donde hace clic con el mouse y cuando haga clic en los rectángulos, los eliminará de la aplicación. 
- Esta técnica será muy útil para el desarrollo de juegos, ya que podemos agregar o eliminar dinámicamente objetos de la pantalla según sea necesario.
- Estamos utilizando Microsoft Visual Studio 2017 para crear esta aplicación que puede seguir junto con cualquier versión que admita la aplicación de formulario WPF.

- Objetivos de este proyecto:

  - Crear una aplicación que agrega y elimina todos los cuadriláteros de la escena.
  - Crear eventos de clic del mouse para trabajar con el elemento del lienzo en WPF.
  - Capturar la ubicación del click del mouse y agregue cuadriláteros a esa ubicación.
  - Capturar los clicks del mouse a los cuadriláteros y eliminar el cuadrilátero en el que se hizo click.
  - Agregar colores aleatorios a los cuadriláteros para que los reconozca en el sistema.

### Tutoriales escritos y código fuente a continuación:

- Abra Visual Studio e inicie un nuevo proyecto.

  ![image](https://github.com/MARSFOREVER472/AgregarOEliminarElementos/assets/69094327/7226c288-8115-4531-a695-92c2334f766a)

- Nómbrelo Agregar y quitar elementos dinámicamente y haga clic en Aceptar.
- Asegúrese de guardar este archivo de proyecto en una ubicación donde pueda encontrarlo nuevamente.

  ![image](https://github.com/MARSFOREVER472/AgregarOEliminarElementos/assets/69094327/9803c6b5-ed27-494a-bf2f-f55cda46544e)

- Esta es la vista predeterminada del proyecto hasta el momento. Haremos algunos cambios en la parte inferior del código aquí.

  ![image](https://github.com/MARSFOREVER472/AgregarOEliminarElementos/assets/69094327/09a4e2fb-46a4-4f9e-94f9-ca58c403188f)

- Agregue la parte resaltada al título de la aplicación, esto activará el administrador de enfoque y mantendrá el lienzo principal enfocado mientras se ejecuta la aplicación.

  ![image](https://github.com/MARSFOREVER472/AgregarOEliminarElementos/assets/69094327/e7303699-a388-408f-8543-087f3b304d22)

- Necesitamos eliminar esta cuadrícula y agregar lienzo aquí.

  ![image](https://github.com/MARSFOREVER472/AgregarOEliminarElementos/assets/69094327/3b453576-6168-47d3-8985-51337bccdf4a)

- Este lienzo que agregamos tiene sus propias propiedades dentro de él. Primero le dimos un nombre para poder interactuar con él desde el script C#, también configuramos el enfoque enfocable en verdadero.
- Este lienzo tiene un evento con el botón izquierdo del mouse llamado addRemoveItems y tiene un color de fondo blanco.
- El evento agregar eliminar elementos se utilizará para verificar dónde hicimos clic en el lienzo y dónde agregar los elementos.
- Por ahora esto es todo lo que necesitamos para este lienzo. Ahora podemos comenzar a agregar códigos C# para este proyecto.
- Haga clic derecho en la palabra clave addRemoveItems y haga clic en Ir a definición.

  ![image](https://github.com/MARSFOREVER472/AgregarOEliminarElementos/assets/69094327/fdfa76bd-bbde-4bee-890e-d3f16d559893)

- Esto nos llevará a la página del script C# y agregará la definición automáticamente.
- Puedes escribirlo manualmente pero de esta manera es más rápido.

  ![image](https://github.com/MARSFOREVER472/AgregarOEliminarElementos/assets/69094327/93076557-b839-4d4b-adeb-1b79294c6dd5)


  

Kind regards!

***MARSFOREVER472***
