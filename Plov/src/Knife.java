
public class Knife {

	public void Cut_onion(Onion o)
    {
	  if (o.getCut_ready()==false)
      {
          o.setCut_ready(true);

      }
    }
	
	
	public void Cut_meat(Meat m)
    {
	  if (m.getCut_ready()==false)
      {
          m.setCut_ready(true);

      }
    }
	
	public void Cut_carrot(Carrot c)
    {
	  if (c.getCut_ready()==false)
      {
          c.setCut_ready(true);

      }
    }
	
}
