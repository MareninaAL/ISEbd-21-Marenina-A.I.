
public class Stove {
	private Pan pan;
	
	///������� �� �����
	private boolean state;
    public boolean GetState(){
    	return state;
    }
    public void SetState(boolean s){
    	state=s;
    }
	
	// ����� �� ����� ���������� 
	  public Pan GetPan(){ // Pan ��� ��� 
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
