/*
 Controlling the Shopping Cart for Hackster.IO project.
 
 by Carlos Campos on 24 Mar 2022

*/

#include <Servo.h>

Servo myservo;
int command = 0;

void setup() 
{
  Serial.begin(9600);

  pinMode(4,OUTPUT);
  pinMode(5,OUTPUT);
  
  myservo.attach(2, 700, 2500);
  myservo.write(75);
  delay(250);
  myservo.write(112);
  delay(250);
  myservo.write(95);
  delay(250);
}

void loop() 
{
  if(Serial.available() > 0)
  {
    command = Serial.read();
    delay(5);

    if(command == 'F' || command == 'f')
    {
      Serial.println("Cart Forward");
      digitalWrite(5,LOW);
      digitalWrite(4,HIGH);
    }
    if(command == 'B' || command == 'b')
    {
      Serial.println("Cart Back");
      digitalWrite(4,LOW);
      digitalWrite(5,HIGH);
    }
    if(command == 'S' || command == 's')
    {
      Serial.println("Cart Stop");
      digitalWrite(4,LOW);
      digitalWrite(5,LOW);
      myservo.write(95);
    }
    if(command == 'L' || command == 'l')
    {
      Serial.println("Cart Left");
      myservo.write(75);
    }
    if(command == 'R' || command == 'r')
    {
      Serial.println("Cart Right");
      myservo.write(110);
    }
    if(command == 'C' || command == 'c')
    {
      myservo.write(95);
    }
  }
}
