using System.Collections.Generic;
using System.Linq;

namespace Contratos.Domain.Errors
{
    public abstract class ErrorBase
    {
        private List<string> _errors;

        protected ErrorBase()
        {
            _errors = new List<string>();
        }

        public void AddError(string erro)
        {
            _errors ??= new List<string>();
            _errors.Add(erro);
        }

        public void AddError(IEnumerable<string> errors)
        {
            errors ??= new List<string>();
            foreach (var error in errors) AddError(error);
        }

        public void AddError(ErrorBase baseError) =>
            AddError(baseError?.GetErrors());

        public void AddError(IEnumerable<ErrorBase> baseErrors) =>
            baseErrors?.ToList().ForEach(AddError);

        public List<string> GetErrors() => _errors;

        public bool IsValid()
        {
            if (_errors == null) return false;
            return !_errors.Any();
        }
    }
}