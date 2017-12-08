package src;

public class ClassArray <T extends IInstrument> {
	 	private T[] places;
	 	private T defaultValue;
	 
	 	public ClassArray(int size, T defVal)
	 	{
	 		defaultValue = defVal;
	 		places = (T[]) new IInstrument[size];
	 		for(int i = 0; i < places.length; i++)
	 		{
	 			places[i] = defaultValue;
	 	}
	 	}
	 	
	 	public static <T extends IInstrument> int plus(ClassArray<T> p, T Saxophone)
	 	{
	 		for(int i = 0; i < p.places.length; i++)
	 	{
	 		if (p.checkFree(i))
	 			{
	 				p.places[i] = Saxophone;
	 				return i;
	 			}
	 		}
	 		return -1;
	 	}
	 
	 	public static <T extends IInstrument> T minus(ClassArray<T> p, int index)
	 	{
	 		if (!p.checkFree(index))
	 	{
	 			T Saxophone = p.places[index];
	 			p.places[index] = p.defaultValue;
	 			return Saxophone;
	 		}
	 	return p.defaultValue;
	 	}
	 
	 	public boolean checkFree(int index)
	 	{
	 		if (index < 0 || index > places.length) return false;
	 	if (places[index] == null) return true;
	 		if (places[index].equals(defaultValue)) return true;
	 
	 		return false;
	 	}
	 	
	 	public T getObject(int index)
	 {
	 		if (index > -1 && index < places.length) return places[index];
	 
	 		return defaultValue;
	 	}
	 
	 }
