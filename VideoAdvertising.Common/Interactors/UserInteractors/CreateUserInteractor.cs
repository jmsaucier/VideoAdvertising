using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdvertising.Common.Interfaces.DataAccessInterfaces;
using VideoAdvertising.Common.Interfaces.InteractorsInterfaces.UserInteractorsInterfaces;
using VideoAdvertising.Common.Interfaces.ObjectInterfaces;
using VideoAdvertising.Common.Interfaces.RequestInterfaces;
using VideoAdvertising.Common.Interfaces.ResponseInterfaces.UserResponseInterfaces;
using VideoAdvertising.Common.Interfaces.ValidatorInterfaces;
using VideoAdvertising.Common.Objects.ModelObjects;
using VideoAdvertising.Common.Objects.ResponseObjects;
using VideoAdvertising.Common.Objects.ResponseObjects.ValidatorResponses;

namespace VideoAdvertising.Common.Interactors.UserInteractors
{
    public class CreateUserInteractor : ICreateUser
    {
        private IUserRepository _repository;
        private IValidator<IUser> _userValidator;
        private IValidator<ICreateUserRequest> _requestValidator;

        public CreateUserInteractor(IUserRepository repository, IValidator<IUser> userValidator, 
            IValidator<ICreateUserRequest> requestValidator)
        {
            _repository = repository;
            _userValidator = userValidator;
            _requestValidator = requestValidator;
        }

        public ICreateUserResponse CreateUser(ICreateUserRequest request)
        {
            AggregateValidatorResponse validatorResponse = new AggregateValidatorResponse();
            validatorResponse.AddValidatorResponse(_requestValidator.Validate(request));

            User user = new User {Email = request.Email, Username = request.Username};
            validatorResponse.AddValidatorResponse(_userValidator.Validate(user));

            if (!validatorResponse.Passed)
            {
                return new CreateUserResponse(validatorResponse);
            }

            IUser storedUser = _repository.Store(user);

            return new CreateUserResponse { User = storedUser, Successful = true, Messages = new List<string>() };
        }
    }
}
