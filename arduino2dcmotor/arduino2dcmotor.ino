int incomingByte = 0;
//TX/RX Flags
int tx=0;
//pins values
int ina=LOW;
int inb=LOW;
void setup()
{
  // initialize digital pin 13 as an output.
  //pinMode(13, OUTPUT);
  // initialize pins INA(13), INB(12)
  pinMode(13, OUTPUT);
  pinMode(12, OUTPUT);
  // initialize PWN pin (10)
  pinMode(10, OUTPUT);
  Serial.begin(9600);
}

void loop()
{
  if (Serial.available() > 0) 
  {
    // set pins INA(13), INB(12) value
    digitalWrite(13, ina);
    digitalWrite(12, inb);
    // set PWN (10) value
    analogWrite(10, 127);
    
    // read the incoming byte:
    incomingByte = Serial.read();
        
    switch(incomingByte)
    {
      //init/end tx
      case 255:
        tx = (tx==0) ? 1:0;
        break;
      //move DC motor fordward
      case 10:
        if(tx==1)
          ina=HIGH;inb=LOW;
        break;
      //mode DC motor backwards
      case 20:
        if(tx==1)
          ina=LOW;inb=HIGH;
        break;
      //stop DC motor
      case 30:
        if(tx==1)
          ina=LOW;inb=LOW;
        break;
    }
    
    // say what you received in ASCII
    //Serial.println(incomingByte);
  }
}
