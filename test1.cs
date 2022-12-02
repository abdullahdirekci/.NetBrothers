
public class Hello{
    public string SayHello(string who){
        string cumlecik;
        if (who != "")
        {
            cumlecik = "Hi" + who;
        }
        else
        {
            cumlecik = "Hello world";
        }
        return cumlecik;
    }
}

public static void main(string[] args){
    Hello hi = new Hello();
    hi.SayHello("Mert");
}