package src;

import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Frame;
import java.awt.Graphics;

import javax.swing.JColorChooser;
import javax.swing.JFrame;
import javax.swing.JButton;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JSpinner;
import javax.swing.JCheckBox;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Form1 {

	private JFrame frame;
	private JTextField textField_Weight;
	private JTextField textField_Price;
	private JTextField textField_Volume;
	
	Color color ; 
	Color dopColor; 
	int weight; 
	int volume; 
	int price; 
	
	boolean bend;
	boolean button;
	boolean mouthpiece;
	
	private IInstrument inst;
	

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
		color = Color.RED;
 		dopColor = Color.BLACK;
 		volume = 45;
 		price = 0;
 		weight = 3000;
		initialize();
	}
	
	private boolean checkFields() {
 		if (checkParse(textField_Weight.getText()) && checkParse(textField_Price.getText()) && checkParse(textField_Volume.getText()) ) {
 			
 			weight = Integer.parseInt(textField_Weight.getText());
 			volume = Integer.parseInt(textField_Volume.getText());
 			price = Integer.parseInt(textField_Price.getText());
 			return true;
 		}

 		return false;
 	}

private boolean checkParse(String str) {
 		try {
			Integer.parseInt(str);
 		} catch (NumberFormatException e) {
 			return false;
 		}
 		return true;
 	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 491, 416);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JCheckBox check_mouthpiece = new JCheckBox("mouthpiece");
		check_mouthpiece.setBounds(225, 281, 97, 23);
		frame.getContentPane().add(check_mouthpiece);
		
		JCheckBox check_button = new JCheckBox("button");
		check_button.setBounds(225, 311, 97, 23);
		frame.getContentPane().add(check_button);
		
		JCheckBox check_bend = new JCheckBox("bend");
		check_bend.setBounds(225, 343, 97, 23);
		frame.getContentPane().add(check_bend);
		
		
		JPanel panel = new JPanel();
			panel.setBounds(10, 10, 365, 238);
			frame.getContentPane().add(panel);
		
			
			JButton btnColor = new JButton("color");
			 		btnColor.setForeground(color);
			 		btnColor.addActionListener(new ActionListener() {
			 			public void actionPerformed(ActionEvent arg0) {
			 
			 				Color initialBackground = btnColor.getForeground();
			 				Color foreground = JColorChooser.showDialog(null, "JColorChooser Sample", initialBackground);
			 				if (foreground != null) {
			 					btnColor.setForeground(foreground);
			 				}
			 				color = foreground;
			 			}
			 		});
			 		btnColor.setBounds(10, 342, 70, 25);
			 		frame.getContentPane().add(btnColor);	
			 		
			 		JButton btnDopColor = new JButton("Dopcolor");
			 		btnDopColor.setForeground(color);
			 		btnDopColor.addActionListener(new ActionListener() {
			 			public void actionPerformed(ActionEvent arg0) {
			 
			 				Color initialBackground = btnDopColor.getForeground();
			 				Color foreground = JColorChooser.showDialog(null, "JColorChooser Sample", initialBackground);
			 				if (foreground != null) {
			 					btnDopColor.setForeground(foreground);
			 				}
			 				color = foreground;
			 			}
			 		});
			 		btnDopColor.setBounds(323, 290, 90, 25);
			 		frame.getContentPane().add(btnDopColor);
			 		
			 		
			
		JButton set_Trumpet = new JButton("Задать трубу");
		set_Trumpet.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (checkFields())
	            {
					if (volume<75 && volume>10) {
	                inst = new Wind_Musical_Instrument(weight, color, price, volume);
	                Graphics gr = panel.getGraphics();
	                gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
	                inst.Draw_Wind_Instrument(gr);
					}
	            }	
			}
		});
		set_Trumpet.setBounds(92, 343, 114, 23);
		frame.getContentPane().add(set_Trumpet);
		
		JButton set_Saxophone = new JButton("Задать саксофон");
		set_Saxophone.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				if (checkFields())
	            {
					bend = check_bend.isSelected();
					button = check_button.isSelected();
					mouthpiece = check_mouthpiece.isSelected();
	                inst = new Saxophone(weight, color, dopColor, price, volume, bend, button, mouthpiece);
	                Graphics gr = panel.getGraphics();
	                gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
	                inst.Draw_Wind_Instrument(gr);
	            }
			}
		});
		set_Saxophone.setBounds(323, 320, 145, 23);
		frame.getContentPane().add(set_Saxophone);
		
		JButton set_Sound = new JButton("Звук!");
		set_Sound.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				if (inst != null)
	            {
					 Graphics gr = panel.getGraphics();
		                gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
		                inst.DrawDoing(gr);
	 

	            }
				
			}
		});
		set_Sound.setBounds(323, 348, 89, 23);
		frame.getContentPane().add(set_Sound);
		
		textField_Weight = new JTextField();
		textField_Weight.setBounds(52, 287, 86, 20);
		frame.getContentPane().add(textField_Weight);
		textField_Weight.setColumns(10);
		
		textField_Price = new JTextField();
		textField_Price.setBounds(52, 312, 86, 20);
		frame.getContentPane().add(textField_Price);
		textField_Price.setColumns(10);
		
		JLabel label = new JLabel("\u0412\u0415\u0441");
		label.setBounds(10, 290, 35, 14);
		frame.getContentPane().add(label);
		
		JLabel lblPrice = new JLabel("Price");
		lblPrice.setBounds(10, 318, 35, 14);
		frame.getContentPane().add(lblPrice);
		
		JLabel lblVolume = new JLabel("Volume");
		lblVolume.setBounds(10, 262, 46, 14);
		frame.getContentPane().add(lblVolume);
		
		textField_Volume = new JTextField();
		textField_Volume.setBounds(52, 259, 86, 20);
		frame.getContentPane().add(textField_Volume);
		textField_Volume.setColumns(10);
		
	
	}
	
	
}
