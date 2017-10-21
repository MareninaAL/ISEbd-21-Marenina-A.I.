package src;

import java.awt.Color;
import java.awt.Graphics;

public class Saxophone extends Wind_Musical_Instrument {

	 private Color dopColor;
     private boolean button ;
     private boolean bend; 
     private boolean mouthpiece;
	
	public Saxophone(double Weight, Color color,  Color dopColor,  double Price,
			int MaxCountVolume, boolean bend, boolean button, boolean mouthpiece) {
		super(Weight, color, Price, MaxCountVolume);
		this.dopColor = dopColor; 
        this.bend = bend;
        this.button = button;
        this.mouthpiece = mouthpiece; 
	}
	
	@Override
	 protected void DrawTrumpet(Graphics g)
     {
       
         super.DrawTrumpet(g);
         
         if (bend)
         { 
             g.drawLine( startPosX , startPosY+50, startPosX , startPosY + 80);
             g.drawArc( startPosX, startPosY + 50, 45, 62,160,185);
             g.drawLine( startPosX+43, startPosY + 94, startPosX+43, startPosY + 75);
             g.drawOval(startPosX + 16, startPosY + 65, 28, 15);
             g.drawLine( startPosX + 12, startPosY + 60, startPosX + 12, startPosY + 85);
             g.drawLine( startPosX + 12, startPosY + 85, startPosX + 15, startPosY + 70);
         }
         
         if (mouthpiece)
         {
        	
             g.drawLine( startPosX+2 , startPosY -7 , startPosX -7, startPosY-23 );
             g.drawLine( startPosX+8, startPosY-7, startPosX - 7, startPosY - 30);
         }

         if (button)
         {
             g.fillOval( startPosX +2, startPosY + 15 , 7 , 7);
             g.fillOval( startPosX + 2, startPosY + 29, 7, 7);
             g.fillOval( startPosX + 2, startPosY + 41, 7, 7);
             g.fillOval( startPosX + 9, startPosY + 15, 7, 7);
             g.fillOval( startPosX + 9, startPosY + 29, 7, 7);
             g.fillOval( startPosX + 9, startPosY + 41, 7, 7);

             g.setColor(Color.BLACK);
             g.drawOval( startPosX + 2, startPosY + 15, 8, 8);
             g.drawOval( startPosX + 2, startPosY + 29, 8, 8);
             g.drawOval( startPosX + 2, startPosY + 41, 8, 8);
             g.drawOval( startPosX + 9, startPosY + 15, 8, 8);
             g.drawOval( startPosX + 9, startPosY + 29, 8, 8);
             g.drawOval( startPosX + 9, startPosY + 41, 8, 8);
         }

       

     }
	
}
