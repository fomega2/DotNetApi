namespace DotNetApi.Helpers.DTOs
{
    public class ResultDto
    {
        public bool IsSuccess {get; set;}
        public string Msg {get; set;}

        public ResultDto Success(string msg){
            return new ResultDto(){
                Msg = msg,
                IsSuccess = true
            };
        }

        public ResultDto Error(string msg){
            return new ResultDto(){
                Msg = msg,
                IsSuccess = false
            };
        }
    }
}