package src;
import java.awt.Color;
import java.awt.Graphics;

public abstract class Musical_Instrument implements IInstrument {

	protected int startPosY; 
    protected int startPosX;
    
    public double  Price = 0;
    public double Weight = 0;
    public double Max_Volume = 0;
    protected int countVolume; 
    
    public Color color;

    public abstract void Draw_Wind_Instrument(Graphics g);

    public abstract void DrawDoing(Graphics g);


    public void SetPosition(int x, int y)
    {
        startPosX = x;
        startPosY = y;
    }

    protected abstract void setWeight(int w);
    public abstract double getWeight();

    protected abstract void setPrice(int p);
    public abstract double getPrice();
   
   
    protected abstract void setMax_Volume(int v);
    public abstract double getMax_Volume();


    public void Volume(int count )
    {
       if (countVolume + count < Max_Volume)
        {
            countVolume += count; 
        }
    }


    public int GetVolume()
    {
        int count = countVolume;
        countVolume = 0;
        return count; 
    }
}
