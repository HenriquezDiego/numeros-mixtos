# Operaciones con Números Mixtos

Este es un pequeño programa en C# que permite realizar operaciones con números mixtos y fracciones. Además, utiliza el método de Euclides para simplificar fracciones a su forma más reducida.

## Requisitos

- Visual Studio (o cualquier otro entorno de desarrollo para C#)

## Uso

1. Descarga o clona este repositorio en tu computadora.
2. Abre el archivo `NumerosMixtos.sln` en Visual Studio (o cualquier otro entorno de desarrollo para C#).
3. Agrega la referencia a la biblioteca en tu proyecto.

## Funcionalidades

Este programa permite realizar las siguientes operaciones:

- Suma
- Resta
- Multiplicación
- División

Además, el programa también incluye la funcionalidad de simplificar fracciones a su forma más reducida utilizando el método de Euclides.

## Método de Euclides para simplificación de fracciones

El método de Euclides, también conocido como algoritmo de Euclides, es un algoritmo para encontrar el máximo común divisor (MCD) de dos números enteros. El MCD es el número más grande que divide exactamente a ambos números.

El método de Euclides se basa en la siguiente idea: si m > n, entonces el MCD de m y n es igual al MCD de n y el resto de la división de m entre n. Por ejemplo, si m = 21 y n = 15, entonces el resto de la división de m entre n es 6 (porque 21 = 1 x 15 + 6). Entonces, el MCD de 21 y 15 es igual al MCD de 15 y 6. Luego, se puede aplicar el mismo proceso para encontrar el MCD de 15 y 6, y así sucesivamente hasta que se llegue a un par de números donde uno sea 0. En ese punto, el MCD es igual al otro número.

Para simplificar una fracción, se puede utilizar el método de Euclides para encontrar el MCD del numerador y el denominador. Luego, se divide el numerador y el denominador por el MCD para obtener la fracción simplificada.

En el programa de operaciones con números mixtos en C#, se utiliza el método de Euclides para simplificar las fracciones que se obtienen en las operaciones aritméticas. Esto se hace dividiendo el numerador y el denominador por su MCD usando una función llamada "SimplificarFraccion". Esto garantiza que las fracciones siempre se simplifiquen a su forma más reducida.
