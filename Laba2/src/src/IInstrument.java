package src;
import java.awt.Color;
import java.awt.Graphics;

public interface IInstrument {
  
	 void SetPosition(int x, int y ); 

     void Draw_Wind_Instrument(Graphics g); 
     
      void DrawDoing (Graphics g) ; 
      
      void Volume (int x); 

      int  GetVolume(); 
      
      void setMainColor(Color color); 
	
}
