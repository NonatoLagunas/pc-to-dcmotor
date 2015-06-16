//Data to receive from PC
int incomingByte = 0;
//TX/RX Flags
int tx=0;
/////-----PINS CONFIGURATION-----/////
//Pins assignment
int pin_INA=13;
int pin_INB=12;
int pin_PWM=10;
//Pins values
int pin_INAValue=LOW;
int pin_INBValue=LOW;
int pin_PWMValue=127;
void setup()
{
  // initialize pins INA, INB
  pinMode(pin_INA, OUTPUT);
  pinMode(pin_INB, OUTPUT);
  // initialize PWN pin
  pinMode(pin_PWM, OUTPUT);
  
  Serial.begin(9600);
}

void loop()
{  
  // set pins INA, INB value
  digitalWrite(pin_INA, pin_INAValue);
  digitalWrite(pin_INB, pin_INBValue);
  // set PWN value
  analogWrite(pin_PWM, pin_PWMValue);
    
  //Check if it ios any data on the serial port
  if (Serial.available() > 0) 
  {    
    // read the incoming byte:
    incomingByte = Serial.read();

    //check th received data
    switch(incomingByte)
    {
      //init/end tx
      case 255:
        tx = (tx==0) ? 1:0;
        break;
      //move DC motor clockwise
      case 10:
        if(tx==1)
          pin_INAValue=HIGH;
          pin_INBValue=LOW;
        break;
      //mode DC motor counterclockwise
      case 20:
        if(tx==1)
          pin_INAValue=LOW;
          pin_INBValue=HIGH;
        break;
      //stop DC motor
      case 30:
        if(tx==1)
          pin_INAValue=LOW;
          pin_INBValue=LOW;
        break;
    }
  }
}
