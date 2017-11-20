package src;

import java.awt.Color;
import java.awt.Graphics;

public class Magazine {
	ClassArray<IInstrument> magazine;

	int countPlaces = 12;
	int placeSizeWidth = 210;
	int placeSizeHeight = 120;

	public Magazine() {
		magazine = new ClassArray<IInstrument>(countPlaces, null);
	}

	public int PutSaxophoneInMagazine(IInstrument Saxophone) {
		return magazine.plus(magazine, Saxophone);
	}

	public IInstrument GetSaxophoneInMagazine(int ticet) {
		return magazine.minus(magazine, ticet);
	}

	public void draw(Graphics g, int width, int height) {
		drawMarking(g);
		for (int i = 0; i < countPlaces; i++) {
			IInstrument Saxophone = magazine.getObject(i);
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
