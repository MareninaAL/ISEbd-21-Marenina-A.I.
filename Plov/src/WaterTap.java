
public class WaterTap {

	 private boolean open=false;
	 
	    public boolean GetOpen(){
	    	return open;
	    	
	    }
	    
	    public void SetOpen(boolean o){
	    	open=o;
	    }
	    
	    public void Wash_rice(Rice rice)
	     {
	         if (open)
	         {
	             rice.SetDirty(false);
	         }
	     }
	    
	    public void Wash_carrot(Carrot carrot)
	     {
	         if (open)
	         {
	        	 carrot.SetDirty(false);
	         }
	     }
	    
	    public void Wash_onoin(Onion onion)
	     {
	         if (open)
	         {
	        	 onion.SetDirty(false);
	         }
	     }
	    
	    public void Wash_meat(Meat meat)
	     {
	         if (open)
	         {
	        	 meat.SetDirty(false);
	         }
	     }
	    
}
