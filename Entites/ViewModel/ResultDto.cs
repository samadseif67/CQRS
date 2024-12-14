using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.ViewModel
{
    public class ResultDto<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public List<string> LstError { get; set; }
        public T Data { get; set; }


        public static ResultDto<T> ResultError(string ErrorMsg)
        {
            var result = new ResultDto<T>();
            result.Message = ErrorMsg;
            result.IsSuccess = false;
            return result;
        }
        public static ResultDto<T> ResultLstError(List<string> LstError)
        {
            var result = new ResultDto<T>();
            result.LstError = LstError;
            result.IsSuccess = false;
            return result;
        }
        public static ResultDto<T> ResultSuccess(T obj)
        {
            var result = new ResultDto<T>();
            result.IsSuccess = true;
            result.Data = obj;
            return result;
        }


    }
}
