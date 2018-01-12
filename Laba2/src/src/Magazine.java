package src;

import java.awt.Color;
import java.awt.Graphics;
import java.util.ArrayList;

public class Magazine {
	 ArrayList<ClassArray<IInstrument>> magazineStages;  

	int countPlaces = 12;
	int placeSizeWidth = 210;
	int placeSizeHeight = 120;
	
	int currentLevel;

	public Magazine(int countStages ) {
		 magazineStages = new ArrayList<ClassArray<IInstrument>>(countStages); 
	        
         for (int i=0; i<countStages;  i++)
         {
        	 magazineStages.add(new ClassArray<IInstrument>(countPlaces, null));
         }
	}
	
	public int getCurrentLevel(){
		 			return currentLevel;	
		 	}
		 
		 	public void levelUp(){
		 		if (currentLevel + 1 < magazineStages.size()) currentLevel++;
		 	}
		 
		 	public void levelDown(){
		 		if (currentLevel > 0) currentLevel--;
		  	}

	public int PutSaxophoneInMagazine(IInstrument Saxophone) {
		return magazineStages.get(currentLevel).plus(magazineStages.get(currentLevel), Saxophone);
	}

	public IInstrument GetSaxophoneInMagazine(int ticet) {
		return magazineStages.get(currentLevel).minus(magazineStages.get(currentLevel), ticet);
	}

	public void draw(Graphics g, int width, int height) {
		drawMarking(g);
		for (int i = 0; i < countPlaces; i++) {
			IInstrument Saxophone = magazineStages.get(currentLevel).getSaxophone(i);
			if (Saxophone != null) {
				Saxophone.SetPosition(4 + i / 4 * placeSizeWidth + 30, i % 4
						* placeSizeHeight + 20);

				Saxophone.Draw_Wind_Instrument(g);
			}
		}

	}

	public void drawMarking(Graphics g) {
		g.setColor(Color.BLACK);
		g.drawRect(0, 0, (countPlaces / 4) * placeSizeWidth-100, 480);
		for (int i = 0; i < countPlaces / 4; i++) {
			for (int j = 0; j < 4; j++) {
				g.drawLine(i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth
						+ 110, j * placeSizeHeight);
				
			}
			g.drawLine(i * placeSizeWidth+110, 0, i * placeSizeWidth+110, 400);
		}

	}
}