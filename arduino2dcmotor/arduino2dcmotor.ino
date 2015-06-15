int incomingByte = 0;
//TX/RX Flags
int tx=0;
void setup()
{
  // initialize digital pin 13 as an output.
  pinMode(13, OUTPUT);
  Serial.begin(9600);
}

void loop()
{
  if (Serial.available() > 0) 
  {
    // read the incoming byte:
    incomingByte = Serial.read();
        
    switch(incomingByte)
    {
      //init/end tx
      case 255:
        tx = (tx==0) ? 1:0;
        break;
      //move DC motor fordward
      case 100:
        if(tx==1)
          digitalWrite(13, HIGH);
        break;
      //mode DC motor backwards
      case 110:
        if(tx==1)
          digitalWrite(13, LOW);
        break;
      //stop DC motor
      case 200:
        if(tx==1)
          digitalWrite(13, HIGH);
          delay(1000);
          digitalWrite(13, LOW);
        break;
    }
    
    // say what you received in ASCII
    //Serial.println(incomingByte);
  }
}
