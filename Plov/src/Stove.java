
public class Stove {
	private Pan pan;
	
	///ключена ли плита
	private boolean state;
    public boolean GetState(){
    	return state;
    }
    public void SetState(boolean s){
    	state=s;
    }
	
	// имеет ли плита сковородку 
	  public Pan GetPan(){ // Pan как тип 
	    return pan;
	    }
	    public void SetPan(Pan p){
	    	pan=p;
	    }
	    

	
	 public void Cooking()
	    {
	            	//pan.IsReady1=true;
		 pan.Cook();
	        }
	 
	 public void Cooking2()
	    {
	            	//pan.IsReady1=true;
		 pan.Cook2();
	        }
}
