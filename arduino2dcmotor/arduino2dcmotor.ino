int incomingByte = 0;
//valores
int m1_pos=0;
int m1_vel=0;
int m2_pos=0;
int m2_vel=0;
//flags
int tx=0;
int recibiendo_m1_vel=0;
int recibiendo_m1_pos=0;
int recibiendo_m2_vel=0;
int recibiendo_m2_pos=0;

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
    
    if(recibiendo_m1_vel==1)
    {
      m1_vel=incomingByte;
      recibiendo_m1_vel=0;
      Serial.println(m1_vel);
      return;
    }
    if(recibiendo_m1_pos==1)
    {
      m1_pos=incomingByte;
      recibiendo_m1_pos=0;
      Serial.println(m1_pos);
      return;
    }
    if(recibiendo_m2_vel==1)
    {
      m2_vel=incomingByte;
      recibiendo_m2_vel=0;
      Serial.println(m2_vel);
      return;
    }
    if(recibiendo_m2_pos==1)
    {
      m2_pos=incomingByte;
      recibiendo_m2_pos=0;
      Serial.println(m2_pos);
      return;
    }
    
    switch(incomingByte)
    {
      case 255:
        tx = (tx==0) ? 1:0;
        break;
      case 100:
        if(tx==1)
          recibiendo_m1_vel=1;
        break;
      case 110:
        if(tx==1)
          recibiendo_m1_pos=1;
        break;
      case 200:
        if(tx==1)
          recibiendo_m2_vel=1;
        break;
      case 210:
        if(tx==1)
          recibiendo_m2_pos=1;
        break;
    }
    
    // say what you received in ASCII
    //Serial.println(incomingByte);
  }
}
