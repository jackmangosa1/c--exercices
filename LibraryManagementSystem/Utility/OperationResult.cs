namespace LibraryManagementSystem.Utilities
{
    public class OperationResult<T>
    {
        public Boolean Success { get; set; }
        public string Message { get; set; }
        public T? Data { get; set; }



        public OperationResult(Boolean Success, string Message, T? Data)
        {
            this.Success = Success;
            this.Message = Message;
            this.Data = Data;
        }




    }
}
