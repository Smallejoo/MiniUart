📌 UART Communication Simulator (WinForms)

A small WinForms app that helps configure, test, and simulate UART communication.
Useful for checking serial settings and sending/receiving data over COM ports.

🔌 How to Use
✔ Best practice with NO hardware:

Use a virtual COM pair (example: com0com, com2com, VSPE, etc.).
Open two instances of this app:

App #1 → COM10

App #2 → COM11

Press Connect → start sending & receiving

✔ With real hardware:

Use any USB–TTL UART adapter or embedded board that supports UART.
Connect TX ↔ RX and GND ↔ GND, then open matching COM ports in the app.

⚙️ Features

Configure UART settings

Baud rate

Data bits

Parity

Stop bits

COM port selection

Send and receive UART messages

Live log window with timestamps

RX activity indicator (LED blink)

Test mode (loopback-like behavior without real hardware)

🧪 What the app is for

Testing UART communication

Checking configuration mismatches

Learning how serial ports work

Debugging embedded devices

Simple PC ↔ PC UART simulation

💻 Tech

C#

.NET WinForms

System.IO.Ports.SerialPort
