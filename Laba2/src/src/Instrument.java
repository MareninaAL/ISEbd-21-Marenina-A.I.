package src;

import java.awt.Graphics;

public interface Instrument {
  
	 void SetPosition(int x, int y ); 

     void Draw_Wind_Instrument(Graphics g); 
     
      void DrawDoing (Graphics g) ; 
      
      void Volume (int x); 

      int  GetVolume(); 
	
}
