namespace Set.Entities{
    class LogRecord{
 

        public string UseName{get; set;}
        public DateTime Instate{get; set;}

       public LogRecord()
        {
            
        }
        

        public override int GetHashCode()
        {
            return UseName.GetHashCode();


        }
        public override bool Equals(object? obj)
        {
            if(!(obj is LogRecord)){
                return false;
            }
            LogRecord other = obj as LogRecord;            
            return UseName.Equals(other.UseName);
        }


    }
}