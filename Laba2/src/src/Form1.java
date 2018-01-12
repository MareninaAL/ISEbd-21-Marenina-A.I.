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
import java.awt.SystemColor;

public class Form1 {

	private JFrame frame;
	Magazine magazine;

	private JTextField num_Place;

	 JPanel panel;
	private String[] elements = new String[6];
	JList listLevels;
	FormSelectTr select;

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
			elements[i] = "уровень " + (i + 1);
		}
		listLevels.setSelectedIndex(magazine.getCurrentLevel());

	}

	private boolean checkPlace(String str) {
		try {
			Integer.parseInt(str);
		} catch (NumberFormatException e) {
			JOptionPane.showMessageDialog(null, "введено не число");
			return false;
		}

		if (Integer.parseInt(str) > 20)
			return false;
		return true;
	}

	/**
	 * Initialize the contents of the frame.
	 */

	public void getInstrument() {

		select = new FormSelectTr(frame);
		if (select.res()) {
			IInstrument instrument = select.getInstrument();
			int place = magazine.PutSaxophoneInMagazine(instrument);
			JOptionPane.showMessageDialog(frame, "место:" + place);
			panel.repaint();
		}
	}

	private void initialize() {
		frame = new JFrame();
		frame.setBounds(10, 10, 750, 610);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		JPanel panel = new Panel(magazine);
		panel.setBackground(SystemColor.textHighlight);
		panel.setBounds(10, 10, 540, 510);
		frame.getContentPane().add(panel);

		JPanel panelTake = new JPanel();
		panelTake.setBounds(567, 357, 148, 176);
		frame.getContentPane().add(panelTake);

		JButton btnRepaint = new JButton("Repaint");
		btnRepaint.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				panel.repaint();
			}
		});
		btnRepaint.setBounds(592, 244, 89, 23);
		frame.getContentPane().add(btnRepaint);

		JButton btn_Buy = new JButton("Купить");
		btn_Buy.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				if (checkPlace(num_Place.getText())) {
					IInstrument instrument = magazine
							.GetSaxophoneInMagazine(Integer.parseInt(num_Place
									.getText()));
					Graphics gr = panelTake.getGraphics();
					gr.clearRect(0, 0, panelTake.getWidth(),
							panelTake.getHeight());
					instrument.SetPosition(30, 30);
					instrument.Draw_Wind_Instrument(gr);
					panel.repaint();
					JOptionPane.showMessageDialog(
							null,
							"вы совершили покупку с места номер  "
									+ num_Place.getText());
				}
			}
		});
		btn_Buy.setBounds(592, 537, 89, 23);
		frame.getContentPane().add(btn_Buy);

		JLabel label = new JLabel("Взять покупку с места");
		label.setBounds(572, 278, 128, 14);
		frame.getContentPane().add(label);

		num_Place = new JTextField();
		num_Place.setBounds(567, 306, 86, 20);
		frame.getContentPane().add(num_Place);
		num_Place.setColumns(10);

		listLevels = new JList(elements);
		listLevels.setBounds(560, 10, 153, 124);
		frame.getContentPane().add(listLevels);

		JButton btnLevelDown = new JButton("<<");
		btnLevelDown.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				magazine.levelDown();
				listLevels.setSelectedIndex(magazine.getCurrentLevel());
				panel.repaint();
			}
		});
		btnLevelDown.setBounds(560, 160, 70, 20);
		frame.getContentPane().add(btnLevelDown);

		JButton btnLevelUp = new JButton(">>");
		btnLevelUp.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				magazine.levelUp();
				listLevels.setSelectedIndex(magazine.getCurrentLevel());
				panel.repaint();
			}
		});
		btnLevelUp.setBounds(640, 160, 70, 20);
		frame.getContentPane().add(btnLevelUp);

		JButton btn_Order = new JButton("Заказ");
		btn_Order.addActionListener(new ActionListener() {
			@SuppressWarnings("deprecation")
			public void actionPerformed(ActionEvent arg0) {
				getInstrument();
			}
		});
		btn_Order.setBounds(592, 214, 89, 23);
		frame.getContentPane().add(btn_Order);
	}
}
