using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.Interfaces.DataAccessInterfaces;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.ValidatorInterfaces;
using VideoAdvertising.Common.Objects.ModelObjects;
using VideoAdvertising.Common.Objects.ResponseObjects.ValidatorResponses;

namespace VideoAdvertising.Common.Objects.ValidatorObjects.UserValidators
{
    public class UserIdExistsValidator : IValidator<IUser>
    {
        private IUserRepository _repository;
        public UserIdExistsValidator(IUserRepository repository)
        {
            _repository = repository;
        }

        public IValidatorResponse Validate(IUser value)
        {
            if (value == null)
            {
                return new SystemFailureValidatorResponse();
            }

            IUser user = _repository.GetById(value.Id);
            IValidatorResponse response = user.Id != string.Empty
                ? new GenericValidatorResponse(true)
                : new GenericValidatorResponse(false, "User Id not found.");
            return response;
        }
    }
}
