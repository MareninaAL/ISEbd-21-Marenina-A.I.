package src;

import java.util.Dictionary;
import java.util.Hashtable;

public class ClassArray <T extends IInstrument> {
	 	
		public Dictionary<Integer, T> places;  
		private int countMax;
	 	private T defaultValue;
	 
	 	public ClassArray(int size, T defVal)
	 	{
	 		defaultValue = defVal;
	 		 places = new Hashtable<Integer, T>();
	            countMax=size; 
	 	}
	 	
	 	public static <T extends IInstrument> int plus(ClassArray<T> p, T Saxophone)
	 	{
	 		if (p.places.size() == p.countMax)
            {
                return -1;
            }
	 		for(int i = 0; i < p.places./*length*/size(); i++)
	 	{
	 		if (p.checkFree(i))
	 			{
	 			p.places.put(i, Saxophone);
	 				return i;
	 			}
	 		}
	 	   p.places.put(p.places.size(), Saxophone);
           return p.places.size() - 1;
	 	}
	 
	 	public static <T extends IInstrument> T minus(ClassArray<T> p, int index)
	 	{
	 		if (p.places.get(index) != null)
	 	{
	 			T Saxophone = p.places.get(index);
	 			 p.places.remove(index);
	 			return Saxophone; 
	 		}
	 	return p.defaultValue;
	 	}
	 
	 	public boolean checkFree(int index)
	 	{

	 		if(places.get(index)==null) return true;
	  		return false;
	 	}
	 	
	 	
	 	public T getSaxophone(int ind) {
	 		 		if(places.get(ind)!=null) return places.get(ind);
	 		  		return defaultValue;
	 		  	}
	 
	 }