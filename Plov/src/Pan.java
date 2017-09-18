import javax.swing.JOptionPane;

public class Pan {
	private Onion[] onion;
	private Meat[] meat;
	private Carrot[] carrot;
	private Rice[] rice;
	private Water[] water;
	private Salt salt;
	private Oil oil;

	public boolean IsReady1 = false;

	public void Init_Onion(int count_Onion) {

		onion = new Onion[count_Onion];
	}

	public void Init_Meat(int count_Meat) {
		meat = new Meat[count_Meat];

	}

	public void Init_Carrot(int count_Carrot) {
		carrot = new Carrot[count_Carrot];

	}

	public void Init_Rice(int count_Rice) {
		rice = new Rice[count_Rice];

	}

	public void Init_Water(int count_Water) {
		water = new Water[count_Water];

	}

	public void AddOnion(Onion o) {
		for (int i = 0; i < onion.length; i++) {
			if (onion[i] == null) {
				onion[i] = o;
				return;
			}
		}
	}

	public void AddMeat(Meat m) {
		for (int i = 0; i < meat.length; i++) {
			if (meat[i] == null) {
				meat[i] = m;
				return;
			}
		}
	}

	public void AddRice(Rice r) {
		for (int i = 0; i < rice.length; i++) {
			if (rice[i] == null) {
				rice[i] = r;
				return;
			}
		}
	}

	public void AddCarrot(Carrot c) {
		for (int i = 0; i < carrot.length; i++) {
			if (carrot[i] == null) {
				carrot[i] = c;
				return;
			}
		}
	}

	public void AddWater(Water w) {
		for (int i = 0; i < water.length; i++) {
			if (water[i] == null) {
				water[i] = w;
				return;
			}
		}
	}

	public void AddSalt(Salt s) {
		salt = s;
		salt.SetCount(true);
	}

	public void AddOil(Oil o) {
		oil = o;
		oil.SetCount(true);
	}

	public boolean Check() {
		if (onion == null)
        {
			 return false;
        }
		if (carrot == null)
        {
			 return false;
        }
		if (meat == null)
        {
			 return false;
        }
		for (int o = 0; o < onion.length; ++o) {
			if (onion[o] == null)
				return false;
		}

		for (int m = 0; m < meat.length; ++m) {
			if (meat[m] == null)
				return false;
		}
		for (int c = 0; c < carrot.length; ++c) {
			if (carrot[c] == null)
				return false;
		}
		
		if (salt==null ) {
			return false; 
			
		}
		if (oil==null ) {
			return false; 
			
		}

		return true;
	}

	public boolean Check2() {
		if (rice == null)
        {
			 return false;
        }
		if (water == null)
        {
			 return false;
        }
		for (int r = 0; r < rice.length; ++r) {
			if (rice[r] == null)
				return false;
		}

		for (int w = 0; w < water.length; ++w) {
			if (water[w] == null)
				return false;
		}
		return true;
	}

	public void Cook() { // метод который готовит ингридиенты
		// !! жарит
		for (int i = 0; i < carrot.length; i++) {
			carrot[i].Cook();
		}
		for (int i = 0; i < onion.length; i++) {
			onion[i].Cook();
		}
		for (int i = 0; i < meat.length; i++) {
			meat[i].Cook();
		}

	}

	public void Cook2() { // метод который готовит ингридиенты
		// !! тушит

		for (int i = 0; i < water.length; i++) {
			water[i].Cook();
		}
		for (int i = 0; i < rice.length; i++) {
			rice[i].Cook();
		}

	}

}
