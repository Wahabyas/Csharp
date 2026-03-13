class Model{
    public string Name;
    public string config = "database_password";
    
    public void SayHellow(){
        Console.WriteLine("Hellow " + Name);
        Console.ReadLine();
    }
    public void SetName(string name){
        Name = name;
    }
    public string Get_config() {
        return this.config;

    }

}

