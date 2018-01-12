package src;

import java.awt.EventQueue;
import java.awt.FlowLayout;
import java.awt.Graphics;
import java.awt.SystemColor;

import javax.swing.JComponent;
import javax.swing.JDialog;
import javax.swing.JFrame;
import javax.swing.JButton;
import javax.swing.JTextField;
import javax.swing.TransferHandler;

import java.awt.datatransfer.DataFlavor;
import java.awt.datatransfer.UnsupportedFlavorException;
import java.awt.dnd.DnDConstants;
import java.awt.dnd.DropTarget;
import java.awt.dnd.DropTargetDragEvent;
import java.awt.dnd.DropTargetDropEvent;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;

import javax.swing.JPanel;
import javax.swing.JLabel;

import java.awt.Color;
import java.io.IOException;

import javax.swing.SwingConstants;
import javax.swing.border.LineBorder;

public class FormSelectTr extends JDialog {

	IInstrument instrument = null;
	JPanel panel;
	public boolean r;

	public FormSelectTr(JFrame parent) {
		super(parent, true);
		main();
	}

	public boolean res() {
		setVisible(true);
		return r;
	}

	public void main() {
		this.getContentPane().setBackground(SystemColor.controlHighlight);
		this.setBounds(100, 100, 550, 350);
		this.setDefaultCloseOperation(JDialog.DISPOSE_ON_CLOSE);
		this.getContentPane().setLayout(null);

		JLabel lblPlane = new JLabel("Trumpet");
		lblPlane.setBounds(44, 29, 77, 17);
		this.getContentPane().add(lblPlane);

		JLabel lblFighter = new JLabel("Saxophone");
		lblFighter.setBounds(44, 64, 77, 17);
		this.getContentPane().add(lblFighter);

		panel = new JPanel();
		FlowLayout flowLayout = (FlowLayout) panel.getLayout();
		panel.setBounds(144, 29, 120, 160);
		this.getContentPane().add(panel);

		MouseListener mouseL = new MouseListener() {

			@Override
			public void mouseClicked(MouseEvent e) {

			}

			@Override
			public void mouseEntered(MouseEvent e) {

			}

			@Override
			public void mouseExited(MouseEvent e) {

			}

			@Override
			public void mousePressed(MouseEvent e) {
				JComponent jc = (JComponent) e.getSource();
				TransferHandler th = jc.getTransferHandler();
				th.exportAsDrag(jc, e, TransferHandler.COPY);
			}

			@Override
			public void mouseReleased(MouseEvent e) {

			}

		};

		lblPlane.addMouseListener(mouseL);
		lblFighter.addMouseListener(mouseL);
		lblFighter.setTransferHandler(new TransferHandler("text"));
		lblPlane.setTransferHandler(new TransferHandler("text"));

		panel.setDropTarget(new DropTarget() {

			public void drop(DropTargetDropEvent e) {

				try {

					for (DataFlavor df : e.getTransferable().getTransferDataFlavors()) {
						if (e.getTransferable().getTransferData(df) == "Trumpet") {
							instrument = new Wind_Musical_Instrument(10, Color.BLACK, 10, 11);
						} else if (e.getTransferable().getTransferData(df) == "Saxophone") {
							instrument = new Saxophone(10, Color.YELLOW, Color.BLACK, 10, 10, true, true, true );
						}
						draw(panel, instrument);
					}
				} catch (Exception ex) {
					System.out.println(ex);
				}

			}

			public void dragEnter(DropTargetDragEvent e) {
				for (DataFlavor df : e.getTransferable().getTransferDataFlavors()) {
					try {
						if (e.getTransferable().getTransferData(df) instanceof String)
							e.acceptDrag(DnDConstants.ACTION_COPY);
						else
							e.acceptDrag(DnDConstants.ACTION_NONE);
					} catch (Exception e1) {
						e1.printStackTrace();
					}
				}
			}
		});

		JLabel lblMainColor = new JLabel("Main Color");
		lblMainColor.setBounds(154, 196, 90, 27);
		this.getContentPane().add(lblMainColor);

		JLabel lblDopColor = new JLabel("Dop Color");
		lblDopColor.setBounds(154, 234, 90, 27);
		this.getContentPane().add(lblDopColor);

		lblMainColor.setDropTarget(new DropTarget() {

			public void drop(DropTargetDropEvent e) {
				if (instrument != null) {
					try {
						for (DataFlavor df : e.getTransferable().getTransferDataFlavors()) {
							instrument.setMainColor((selectColor(e.getTransferable().getTransferData(df).toString())));
							draw(panel, instrument);
						}
					} catch (Exception ex) {
						System.out.println(ex + "FF");
					}
				}
			}

			public void dragEnter(DropTargetDragEvent e) {
				for (DataFlavor df : e.getTransferable().getTransferDataFlavors()) {
					try {
						if (e.getTransferable().getTransferData(df) instanceof String)
							e.acceptDrag(DnDConstants.ACTION_COPY);
						else
							e.acceptDrag(DnDConstants.ACTION_NONE);
					} catch (UnsupportedFlavorException | IOException e1) {
						e1.printStackTrace();
					}
				}
			}
		});
		lblDopColor.setDropTarget(new DropTarget() {

			public void drop(DropTargetDropEvent e) {
				if (instrument != null) {
					try {

						for (DataFlavor df : e.getTransferable().getTransferDataFlavors()) {
							((Saxophone) instrument)
									.SetDopColor((selectColor(e.getTransferable().getTransferData(df).toString())));
							draw(panel, instrument);
						}
					} catch (Exception ex) {
						System.out.println(ex);
					}
				}
			}

			public void dragEnter(DropTargetDragEvent e) {
				for (DataFlavor df : e.getTransferable().getTransferDataFlavors()) {
					try {
						if (e.getTransferable().getTransferData(df) instanceof String)
							e.acceptDrag(DnDConstants.ACTION_COPY);
						else
							e.acceptDrag(DnDConstants.ACTION_NONE);
					} catch (UnsupportedFlavorException | IOException e1) {
						e1.printStackTrace();
					}
				}
			}
		});

		JPanel panelYellow = new JPanel();
		panelYellow.setBorder(new LineBorder(new Color(0, 0, 0)));
		panelYellow.setName("yellow");
		panelYellow.setBackground(Color.YELLOW);
		panelYellow.setBounds(309, 29, 46, 45);
		this.getContentPane().add(panelYellow);

		JPanel panelBlue = new JPanel();
		panelBlue.setBorder(new LineBorder(new Color(0, 0, 0)));
		panelBlue.setName("blue");
		panelBlue.setBackground(Color.BLUE);
		panelBlue.setBounds(387, 29, 46, 45);
		this.getContentPane().add(panelBlue);

		JPanel panelRed = new JPanel();
		panelRed.setBorder(new LineBorder(new Color(0, 0, 0)));
		panelRed.setName("red");
		panelRed.setBackground(Color.RED);
		panelRed.setBounds(309, 83, 46, 45);
		this.getContentPane().add(panelRed);

		JPanel panelGreen = new JPanel();
		panelGreen.setBorder(new LineBorder(new Color(0, 0, 0)));
		panelGreen.setName("green");
		panelGreen.setBackground(Color.GREEN);
		panelGreen.setBounds(387, 83, 46, 45);
		this.getContentPane().add(panelGreen);

		JPanel panelBlack = new JPanel();
		panelBlack.setBorder(new LineBorder(new Color(0, 0, 0)));
		panelBlack.setName("black");
		panelBlack.setBackground(Color.BLACK);
		panelBlack.setBounds(309, 133, 46, 45);
		this.getContentPane().add(panelBlack);

		JPanel panelPink = new JPanel();
		panelPink.setBorder(new LineBorder(new Color(0, 0, 0)));
		panelPink.setName("pink");
		panelPink.setBackground(Color.PINK);
		panelPink.setBounds(387, 133, 46, 45);
		this.getContentPane().add(panelPink);

		JPanel panelMagenta = new JPanel();
		panelMagenta.setBorder(new LineBorder(new Color(0, 0, 0)));
		panelMagenta.setName("magenta");
		panelMagenta.setBackground(Color.MAGENTA);
		panelMagenta.setBounds(309, 187, 46, 45);
		this.getContentPane().add(panelMagenta);

		JPanel panelCyan = new JPanel();
		panelCyan.setBorder(new LineBorder(new Color(0, 0, 0)));
		panelCyan.setName("cyan");
		panelCyan.setBackground(Color.CYAN);
		panelCyan.setBounds(387, 187, 46, 45);
		this.getContentPane().add(panelCyan);

		panelYellow.addMouseListener(mouseL);
		panelYellow.setTransferHandler(new TransferHandler("name"));

		panelBlue.addMouseListener(mouseL);
		panelBlue.setTransferHandler(new TransferHandler("name"));

		panelRed.addMouseListener(mouseL);
		panelRed.setTransferHandler(new TransferHandler("name"));

		panelGreen.addMouseListener(mouseL);
		panelGreen.setTransferHandler(new TransferHandler("name"));

		panelBlack.addMouseListener(mouseL);
		panelBlack.setTransferHandler(new TransferHandler("name"));

		panelPink.addMouseListener(mouseL);
		panelPink.setTransferHandler(new TransferHandler("name"));

		panelMagenta.addMouseListener(mouseL);
		panelMagenta.setTransferHandler(new TransferHandler("name"));

		panelCyan.addMouseListener(mouseL);
		panelCyan.setTransferHandler(new TransferHandler("name"));

		JButton btnAdd = new JButton("Add");
		btnAdd.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				r = true;
				System.out.println("Add" + r);
				dispose();
			}
		});
		btnAdd.setBounds(27, 133, 89, 23);
		this.getContentPane().add(btnAdd);

		JButton btn_close = new JButton("close");
		btn_close.setBounds(27, 187, 89, 23);
		this.getContentPane().add(btn_close);
		btn_close.addActionListener((ActionEvent e) -> {
			r = false;
			dispose();
		});
	}

	public IInstrument getInstrument() {
		System.out.println("fgfgf");
		return instrument;
	}

	public void draw(JPanel panel, IInstrument instrument) {
		if (instrument != null) {
			Graphics gr = panel.getGraphics();
			gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
			instrument.SetPosition(30, 35);
			instrument.Draw_Wind_Instrument(gr);
		}
	}

	public Color selectColor(String s) {
		switch (s) {
		case "yellow":
			return Color.yellow;
		case "blue":
			return Color.blue;
		case "red":
			return Color.red;
		case "green":
			return Color.green;
		case "black":
			return Color.black;
		case "pink":
			return Color.pink;
		case "magenta":
			return Color.magenta;
		case "cyan":
			return Color.cyan;
		}

		return null;
	}
}
