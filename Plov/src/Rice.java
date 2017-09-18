
public class Rice {
	
	private int ready;
	
public int Ready(){
		
		return ready;
	}

	   private boolean dirty = true;
	    public boolean GetDirty (){
	    	return dirty;
	    }
	    public void SetDirty(boolean d){
	    	dirty=d;
	    }
	    
	    private boolean add = false;
	    public boolean GetAdd (){
	    	return add;
	    }
	    public void SetAdd(boolean a){
	    	add=a;
	    }
	    
	    public void Cook()
	    {
	        if (Ready() < 10)
	        {
	            ready++;
	   
	        }
	    }
	
	
}
