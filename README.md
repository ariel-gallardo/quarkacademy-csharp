# Quark
## Desafio Final Curso C#
### Unity Game Developer
---

# Requisitos
* [ASP.NET Core Runtime Win64](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)  
# Instrucciones
1. [Seleccionar branch Main](https://github.com/ariel-gallardo/quarkacademy-csharp/tree/main)
2. [Descargar releases/QuarkAcademy-Csharp.exe](https://github.com/ariel-gallardo/quarkacademy-csharp/tree/main/releases/QuarkAcademy-Csharp.exe)
3. **Ejecutar**

---
# Parte C

1. Ademas, existen dos tipos de prendas: Pantalones y Camisas.
> Las camisas pueden de manga corta o manga larga.
> Las camisas pueden tener cuello mao o cuello comun.
> Los pantalones pueden ser comunes o chupines.

2. Completar el modelo de clases.

3. Es necesario que el programa permita marcar si el tipo de camisa es de manga
corta o manga larga, cuello mao o cuello comun, ya que cada tipo de camisa tiene
un precio diferente a las demas.
> Lo mismo para los pantalones chupines. que tienen un precio diferente a los
pantalones normales.

4. El precio final que calcula el programa (cotizacion) respondera a las siguientes
reglas de negocio:

> Tipo de prenda:
* **RN 1** - Si la camisa es de tipo manga corta el precio se rebaja en un 10%.
* **RN 2** - Si la camisa tiene cuello mao, el precio aumenta en un 3%.
* **RN 3** - Si la camisa es de manga corta y cuello mao. deben aplicarse Ias dos reglas
anteriores (en el orden establecido).
* **RN 4** - Si el pantalon es chupin, el precio se rebaja en un 12%.

> Calidad de prenda:
* **RN 5** - Si la calidad de la prenda es Standard: el precio no se modifica.
* **RN 6** - Si la calidad de la prenda es Premium: el precio aumenta en un 30%.

**Importante**: Las reglas de negocio se deben aplicar de forma incremental,
aplicando primero las de Tipo de prenda, y al resultado, aplicar si corresponde, las
reglas de Calidad.

5. Modificar la implementaciön contemplando los nuevos cambios.


![quarkacademy-csharp drawio (9)](https://user-images.githubusercontent.com/38444032/214454684-a51ab116-4500-4f18-8ce6-ca2e4dc4096f.svg)