package src;
import java.awt.Color;
import java.awt.Graphics;
import java.util.Random;

public class Wind_Musical_Instrument extends Musical_Instrument {

	
	
	@Override
	 	protected void setWeight(int w) {
	 		if (w > 1600 && w <= 3500)
	 			super.Weight = w;
	 		else
	 			super.Weight = 3500;
	 	}
	 
	 	@Override
	 	public double getWeight() {
	 		return super.Weight;
	 	}
	 
	 	@Override
		protected void setPrice(int p) {
	 		if (p > 5000 && p <= 15000)
	 			super.Price = p;
	 		else
	 			super.Price = 15000;
		}

		@Override
		public double getPrice() {
			return super.Price;
		}

		@Override
		protected void setMax_Volume(int v) {
			if (v > 10 && v < 75)
	 			super.Price = v;
	 		else
	 			super.Price = 74;
			
		}

		@Override
		public double getMax_Volume() {
			return super.Max_Volume;
		}


	        public Wind_Musical_Instrument (double Weight, Color color, double Price, int Max_Volume)
	        {
	            this.Weight = Weight;
	            this.color = color;
	            this.Price = Price;
	            this.Max_Volume = Max_Volume; 
	            Random random = new Random(); 
	            startPosX = random.nextInt(300); 
	             startPosY = random.nextInt(180);

	        }

	@Override
	public void DrawDoing(Graphics g) {
		g.setColor(color);
         g.drawOval( startPosX + 60, startPosY, 11, 11);
         g.drawLine( startPosX+70, startPosY-25, startPosX+70, startPosY );
         g.drawLine( startPosX + 70, startPosY - 25, startPosX + 75, startPosY-25);


         g.drawLine( startPosX + 90, startPosY + 12, startPosX + 90, startPosY - 10);
         g.drawLine( startPosX + 90, startPosY - 10, startPosX + 100, startPosY - 10);
         g.drawLine( startPosX + 100, startPosY - 10, startPosX + 100, startPosY + 18);
         g.drawOval( startPosX + 80, startPosY+10, 11, 11);
         g.drawOval( startPosX + 94, startPosY + 10, 11, 11);


         Draw_Wind_Instrument(g);
		
	}
	
	@Override
	public void Draw_Wind_Instrument(Graphics g) {
		
		 DrawTrumpet(g); 
	}
	
	
	 protected void DrawTrumpet(Graphics g)
     {
		 g.setColor(color);
         g.drawLine( startPosX, startPosY, startPosX+2, startPosY-7);
         g.drawLine( startPosX+10, startPosY, startPosX + 8, startPosY - 7);

         g.drawLine( startPosX, startPosY, startPosX, startPosY+45);
         g.drawLine( startPosX+10, startPosY, startPosX+10, startPosY + 45);

         g.drawLine( startPosX, startPosY+45, startPosX-7, startPosY + 51);
         g.drawLine( startPosX + 10, startPosY+45, startPosX + 18, startPosY + 51);
         g.drawOval( startPosX-7, startPosY+49, 25, 8);
     }

	

	
}
