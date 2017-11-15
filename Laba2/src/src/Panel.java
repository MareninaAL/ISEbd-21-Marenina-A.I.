package src;

import java.awt.Graphics;

import javax.swing.JPanel;

public class Panel extends JPanel {

	Magazine m;
	 	public Panel(Magazine mag) {
	 		this.m=mag;
	 	}
	 	
	 	public void paint(Graphics g) {
	 		g.clearRect(0, 0, this.getWidth(), this.getHeight());
	 		m.draw(g, this.getWidth(), this.getHeight());
	 	}
	
}
