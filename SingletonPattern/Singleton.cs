
namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton uniqueInstance;
        private Singleton (){}
        public string name{get;}

        public static Singleton getInstance(){
            if(uniqueInstance == null){
                uniqueInstance = new Singleton();
            }
            return uniqueInstance;
        }

    }
}