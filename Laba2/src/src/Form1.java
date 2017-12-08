package src;

import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Frame;
import java.awt.Graphics;

import javax.swing.JColorChooser;
import javax.swing.JFrame;
import javax.swing.JButton;
import javax.swing.JList;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.JLabel;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Form1 {

	private JFrame frame;
	Magazine magazine;

	private JTextField num_Place;
	
	JPanel panel;
	 	private String[] elements = new String[6];
	 	JList listLevels;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Form1 window = new Form1();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Form1() {

		magazine = new Magazine(4);
		initialize();
		
		for (int i = 0; i < 4; i++) {
			 			elements[i] = "уровень " + (i+1);
					}
					listLevels.setSelectedIndex(magazine.getCurrentLevel());
	}

	private boolean checkPlace(String str) {
		try {
			Integer.parseInt(str);
		} catch (NumberFormatException e) {
			JOptionPane.showMessageDialog(null, "введено не число" );
			return false;
		}
			
		if (Integer.parseInt(str) > 20)
			return false;
		return true;
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(10, 10, 750, 610);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		JPanel panel = new Panel(magazine);
		panel.setBackground(new Color(135, 206, 250));
		panel.setBounds(10, 10, 540, 510);
		frame.getContentPane().add(panel);


		

		JButton set_Trumpet = new JButton("положить трубу");
		set_Trumpet.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				Color colorDialog = JColorChooser.showDialog(null, "JColorChooser Sample", null);
				 				if (colorDialog != null) {
				 					IInstrument Wind_Musical_Instrument = new Wind_Musical_Instrument(1000,colorDialog, 10000, 30 );
				 					int place = magazine.PutSaxophoneInMagazine(Wind_Musical_Instrument);
				 					panel.repaint();
				 					JOptionPane.showMessageDialog(null, "Номер места " + place);
				  				}
				
				
			}
		});
		set_Trumpet.setBounds(560, 11, 135, 30);
		frame.getContentPane().add(set_Trumpet);

		JButton set_Saxophone = new JButton("Положить саксофон");
		set_Saxophone.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				Color colorDialog1 = JColorChooser.showDialog(null,
						"JColorChooser Sample", null);
				
				if (colorDialog1 != null) {
					Color colorDialog = JColorChooser.showDialog(null,
							"JColorChooser Sample", null);
					if (colorDialog != null) {
						IInstrument Wind_Musical_Instrument = new Saxophone(1000,  colorDialog, colorDialog1, 30,30, true, true, true);
						int place = magazine.PutSaxophoneInMagazine(Wind_Musical_Instrument);
						panel.repaint();
						JOptionPane.showMessageDialog(null, "номер " + place);
					}
				}	
					
				
			}
		});
		set_Saxophone.setBounds(560, 45, 155, 30);
		frame.getContentPane().add(set_Saxophone);

		JPanel panelTake = new JPanel();
		panelTake.setBounds(567, 290, 148, 243);
		frame.getContentPane().add(panelTake);

		

		JButton button = new JButton("Купить");
		button.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				if (checkPlace(num_Place.getText())) {
					IInstrument Wind_Musical_Instrument = magazine
							.GetSaxophoneInMagazine(Integer.parseInt(num_Place
									.getText()));
					Graphics gr = panelTake.getGraphics();
					gr.clearRect(0, 0, panelTake.getWidth(),
							panelTake.getHeight());
					Wind_Musical_Instrument.SetPosition(5, 5);
					Wind_Musical_Instrument.Draw_Wind_Instrument(gr);
					panel.repaint();
					JOptionPane.showMessageDialog(null, "вы совершили покупку с места номер  " + num_Place.getText());
				}
			}
		});
		button.setBounds(557, 540, 89, 23);
		frame.getContentPane().add(button);

		JLabel label = new JLabel("Взять покупку с места");
		label.setBounds(567, 86, 128, 14);
		frame.getContentPane().add(label);
		
		num_Place = new JTextField();
		num_Place.setBounds(560, 117, 86, 20);
		frame.getContentPane().add(num_Place);
		num_Place.setColumns(10);
		
		listLevels = new JList(elements);
		listLevels.setBounds(560, 140, 153, 111);
		frame.getContentPane().add(listLevels);
		
		JButton btnLevelDown = new JButton("<<");
		 		btnLevelDown.addActionListener(new ActionListener() {
		 			public void actionPerformed(ActionEvent arg0) {
		 				magazine.levelDown();
		 				listLevels.setSelectedIndex(magazine.getCurrentLevel());
		 				panel.repaint();
		 			}
		 		});
		 		btnLevelDown.setBounds(560, 255, 70, 20);
		 		frame.getContentPane().add(btnLevelDown);

		 		
		 		JButton btnLevelUp = new JButton(">>");
		 		 	btnLevelUp.addActionListener(new ActionListener() {
		 		 			public void actionPerformed(ActionEvent e) {
		 		 				magazine.levelUp();
		 		 				listLevels.setSelectedIndex(magazine.getCurrentLevel());
		 		 				panel.repaint();
		 		 			}
		 		 		});
		 		 		btnLevelUp.setBounds(645, 255, 70, 20);
		 		 		frame.getContentPane().add(btnLevelUp);
	}
}
