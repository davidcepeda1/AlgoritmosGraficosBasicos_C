🌈 Algoritmos de Gráficos por Computadora 🖥️✨

🚀 Descripción del Proyecto
Implementación interactiva de 4 algoritmos fundamentales en gráficos rasterizados:
- 🧮 DDA para líneas rectas
- ⚡ Bresenham optimizado para líneas
- 🔵 Bresenham para circunferencias
- 🎨 Relleno por inundación (Flood Fill)

¡Con animaciones paso a paso y visualización de píxeles en tiempo real!

✨ Características Destacadas
📐 DDA: Trazado de líneas con incrementos flotantes
⚡ Bresenham (Línea): Versión optimizada con solo operaciones enteras
🔵 Bresenham (Círculo): Dibujo eficiente usando simetría de 8 puntos
🌊 Flood Fill: Relleno de polígonos con BFS y ray-casting
🎭 Interfaz MDI (Multi-Document Interface)
⏱️ Animación progresiva de píxeles
📋 Listado de coordenadas en tiempo real
📊 Generador de polígonos regulares

🛠️ Tecnologías Utilizadas
- C#
- Windows Forms
- .NET Framework 4.8
- PictureBox para visualización
- Timer para animaciones
- Graphics para dibujo

⬇️ Instalación y Ejecución
1. Requisitos previos:
   - Visual Studio 2019+
   - .NET Framework 4.8

2. Pasos:
   git clone 
   Abrir AlgoritmoLineas.sln en Visual Studio
   Presionar F5 para ejecutar

🧩 Estructura del Código
/Proyecto

├── Algoritmos

│   ├── DDA.cs                 # Algoritmo DDA

│   ├── Bresenham.cs           # Bresenham para líneas

│   ├── BresenhamCirculo.cs    # Algoritmo para círculos

│   └── RellenoFiguras.cs      # Flood Fill con BFS

│

├── Formularios

│   ├── FrmHome.cs                       # Ventana principal MDI

│   ├── FrmDDA.cs                        # Interfaz DDA

│   ├── FrmBresenham.cs                  # Interfaz Bresenham

│   ├── FrmBresenhamCircunferencias.cs   # Interfaz Bresenhm (Circunferencia)

│   └── FrmRellenoFiguras.cs             # Interfaz para relleno

│

└── Program.cs                 # Punto de entrada

🎯 Casos de Uso
1. Educación:
   - Enseñanza de algoritmos gráficos básicos
   - Visualización interactiva para estudiantes

2. Desarrollo:
   - Base para librerías gráficas
   - Pruebas de rendimiento entre algoritmos

3. Arte Digital:
   - Herramienta para diseños geométricos
   - Generación de patrones complejos

🏆 Contribuciones
¡Tu ayuda es bienvenida! Sigue estos pasos:
1. Fork del proyecto
2. Crea una rama
3. Implementa mejoras
4. Envía Pull Request
5. Revisión y merge

Áreas prioritarias:
🚀 Optimización de rendimiento
🎨 Mejoras en la interfaz gráfica
🧪 Añadir más algoritmos (ej: elipses, curvas)

📜 Licencia
MIT License
Copyright (c) 2025 DavidCepeda

Permite:
- Uso comercial
- Modificaciones
- Distribución
- Uso privado
