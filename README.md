In this project, an application named 'C#-based Manhole Cover Inspection and Monitoring System' is aimed to be implemented.

Here's a summary of the project:

The project consists of 4 sensors, and based on the data from these sensors, 4 corresponding actions are executed.

1) Illumination of the well during nighttime is intended based on the data received from the Light Dependent Resistor (LDR) sensor. 
The lighting process is controlled by adjusting the bulb brightness through a C# interface.

2) The Arduino fan module is activated based on the data obtained from the MQ2 gas module to maintain gas levels within the well. 
The fan speed is controlled through a C# interface.

3) Monitoring of water levels is performed using the HCSR04 Ultrasonic Sensor. When the water level rises, a servo motor located on an additional drain cover is activated to balance the water level.
The speed of the servo motor can be controlled via the C# interface.

4) Another HCSR04 Ultrasonic Sensor measures the water level, and by comparing its readings with a reference value, the presence of any living organism inside is tracked. If a living organism is detected, a buzzer on the cover is activated to alert nearby individuals.
The duration of the buzzer's operation can be set through the C# interface.

This application was implemented using the STM32F446RE NUCLEO board. Embedded software development was conducted using the HAL library through STM32CubeIDE.

Achievements:

Creating a Windows Form application using C#.
STM32 Applications:

GPIO operations
ADC
PWM
UART
TIMER
INTERRUPT
DAC
