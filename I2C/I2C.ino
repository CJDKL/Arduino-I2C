#include <SerialCommand.h>
#include <Wire.h>

SerialCommand sCmd;

byte arr1[8] =  {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr2[8] =  {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr3[8] =  {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr4[8] =  {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr5[8] =  {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr6[8] =  {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr7[8] =  {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr8[8] =  {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr9[8] =  {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr10[8] = {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr11[8] = {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr12[8] = {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr13[8] = {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr14[8] = {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr15[8] = {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr16[8] = {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr17[8] = {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr18[8] = {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr19[8] = {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr20[8] = {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr21[8] = {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr22[8] = {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr23[8] = {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr24[8] = {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr25[8] = {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr26[8] = {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr27[8] = {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr28[8] = {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr29[8] = {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr30[8] = {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr31[8] = {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
byte arr32[8] = {0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF};
void setup() {
  // put your setup code here, to run once:
  pinMode(13,OUTPUT);

  Wire.begin(); //Wire being starts the wire to connect ot I2C
  Serial.begin(9600);
  
  //the addCommand below lets you control the arduino using C#
  sCmd.addCommand("READ", readChip);
  sCmd.addCommand("READHEX", readChipHex);
  sCmd.addCommand("EDIT1", editChip1);
  sCmd.addCommand("EDIT2", editChip2);
  sCmd.addCommand("EDIT3", editChip3);
  sCmd.addCommand("EDIT4", editChip4);
  sCmd.addCommand("WRITE", writeChip);
  sCmd.addCommand("OFF", lightOFF);
  sCmd.addCommand("ON", lightON);
  sCmd.setDefaultHandler(error);  //if c# sends something arduino doesnt know, run this instead
}

void lightOFF(){
  digitalWrite(13, LOW);
}
void lightON(){
  digitalWrite(13, HIGH);
}

void editChip1(){
  for(int i = 0; i < 8; i++){
    arr3[i] = (atoi(sCmd.next()));
  }
}
void editChip2(){
 for(int i = 0; i < 5; i++){
    arr4[i] = (atoi(sCmd.next()));
  }
}
void editChip3(){
 for(int i = 0; i < 4; i++){
    arr5[i] = (atoi(sCmd.next()));
  }
}
void editChip4(){
  for(int i = 0; i < 6; i++){
    arr7[i] = (atoi(sCmd.next()));
  }
}
//this prints the chip for all 16 lines of its hex values
void readChipHex(){
  digitalWrite(13,HIGH);
  Wire.beginTransmission(99);  //setting transmission to 0x00 starts the read form beginning
  Wire.write(0x00);
  Wire.endTransmission();
  Serial.println("Start of file");       
  for(int i = 0; i < 16; i++){
    Wire.requestFrom(99,16);  //gets the next 16 registers and stores it
    String c = "";
    while(Wire.available()){
      c += String(Wire.read(), HEX);  //read the next availabe register
      c += " ";
    }
    Serial.println(c);  //printing it allows c# to catch it
  }
  Serial.println();
}

//this prints the chip for 4 lines in string format
void readChip(){
  int count = 0;
  String c = "";
  
  Wire.beginTransmission(99); //this opens connection to addres 99
  Wire.write(0x00);  //move pointer to  beginning at 0x00
  Wire.endTransmission();  //close connection
  Serial.println("Start of file");      
  //this reads the first 16 registers that contains the words essai 
  count = 0;
  Wire.requestFrom(99,16); //since we moved pointer to start, begin reading. requestFrom(address,size)
  c = "Name: ";
  while(Wire.available()){
    byte a = Wire.read();
    count++;
    if(a > 31 && a < 128 && count <= 13){
      c += (char)(a);
    }else{
      c += " ";
    }
  }
  Serial.println(c);
  
  //this reads the 13 character part number
  count = 0;
  Wire.requestFrom(99,16);
  c = "Part Number: ";
  while(Wire.available()){
    byte a = Wire.read();
    count++;
    if(a > 31 && a < 128 && count <= 13){
      c += (char)(a);
    }else{
      c += " ";
    }
    if(count == 3 || count == 9){
      c += "-";
    }
  }
  Serial.println(c);
  //this reads the 4 digit serial number
  count = 0;
  Wire.requestFrom(99,16);
  c = "Serial Number: ";
  while(Wire.available()){
    byte a = Wire.read();
    count++;
    if(a > 31 && a < 128 && count <= 13){
      c += (char)(a);
    }else{
      c += " ";
    }
  }
  Serial.println(c);
    
  //this reads the 6 digit ddmmyy
  Wire.requestFrom(99,16);
  c = "Manf Date: ";
  String day = "";
  String month = "";
  String year = "20";
  count = 0;
  while(Wire.available()){
    byte a = Wire.read();
    count++;
    if(a > 31 && a < 128 && count <= 6){
      switch(count){
        case 1: year += (char)a; break;
        case 2: year += (char)a; break;
        case 3: month += (char)a; break;
        case 4: month += (char)a; break;
        case 5: day += (char)a; break;
        case 6: day += (char)a; c += (day + "/" + month + "/" + year); break;
      }
    }else{
      c += " ";
    }
  }
  Serial.println(c);
  Serial.println("End of file");    
}
void writeChip(){
  for(int i = 0x00; i <= 0xF8; i+= 0x08){
    Wire.beginTransmission(99); //can send only 8(?) bytes. to send more, end transmission and start a new one
    Wire.write(i); //first write when you open a transmission selects the starting register
    switch(i){
      case 0x00: Wire.write(arr1,8); break;
      case 0x08: Wire.write(arr2,8); break;
      case 0x10: Wire.write(arr3,8); break;
      case 0x18: Wire.write(arr4,8); break;
      case 0x20: Wire.write(arr5,8); break;
      case 0x28: Wire.write(arr6,8); break;
      case 0x30: Wire.write(arr7,8); break;
      case 0x38: Wire.write(arr8,8); break;
      case 0x40: Wire.write(arr9,8); break;
      case 0x48: Wire.write(arr10,8); break;
      case 0x50: Wire.write(arr11,8); break;
      case 0x58: Wire.write(arr12,8); break;
      case 0x60: Wire.write(arr13,8); break;
      case 0x68: Wire.write(arr14,8); break;
      case 0x70: Wire.write(arr15,8); break;
      case 0x78: Wire.write(arr16,8); break;
      case 0x80: Wire.write(arr17,8); break;
      case 0x88: Wire.write(arr18,8); break;
      case 0x90: Wire.write(arr19,8); break;
      case 0x98: Wire.write(arr20,8); break;
      case 0xA0: Wire.write(arr21,8); break;
      case 0xA8: Wire.write(arr22,8); break;
      case 0xB0: Wire.write(arr23,8); break;
      case 0xB8: Wire.write(arr24,8); break;
      case 0xC0: Wire.write(arr25,8); break;
      case 0xC8: Wire.write(arr26,8); break;
      case 0xD0: Wire.write(arr27,8); break;
      case 0xD8: Wire.write(arr28,8); break;
      case 0xE0: Wire.write(arr29,8); break;
      case 0xE8: Wire.write(arr30,8); break;
      case 0xF0: Wire.write(arr31,8); break;
      case 0xF8: Wire.write(arr32,8); break;
    }
    Wire.endTransmission();
    delay(200);
  }
    
    Wire.beginTransmission(99); //can send only 8(?) bytes. to send more, end transmission and start a new one
    Wire.write(0x38); //first write when you open a transmission selects the starting register
    Wire.write(arr8,8);
    delay(100);
    Wire.endTransmission();
    delay(1000);
}

void error(const char *command){
  Serial.println("NA");
}

//void loop() {
//  sCmd.readSerial();
//}
//this finds the ports that are open

void loop(){
  byte error, address;
  int nDevices;
  
  Serial.println("Scanning...");
  nDevices = 0;
  for(address = 1; address <127; address++){
    Wire.beginTransmission(address);
    error = Wire.endTransmission();
    if(error == 0){
      Serial.print("I2C device found at address 0x");
      if(address < 16)
        Serial.print("0");
      Serial.print(address, HEX);
      Serial.println(" !");  
      nDevices++;
    }
    else if(error == 4){
      Serial.print("Unknown error at address 0x");
      if(address < 16)
        Serial.print("0");
      Serial.print(address, HEX);
    }
  }
  if(nDevices == 0)
    Serial.println("No I2C devices found\n");
  else
    Serial.println("done\n");
    delay(5000);
}


