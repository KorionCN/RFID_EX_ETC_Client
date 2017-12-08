

namespace RFID_EX_ETC_Client.Model.Remote {
    class Result<T> {
        private int stateCode;
        private string message;
        private T data;

        public int StateCode { get => stateCode; set => stateCode = value; }
        public string Message { get => message; set => message = value; }
        public T Data { get => data; set => data = value; }

        public static Result<T> FromResponseResult(ResponseResult responceResult, T data) {
            return new Result<T> {
                StateCode = responceResult.StateCode,
                Message = responceResult.Message,
                Data = data
            };
        }
    }
}
