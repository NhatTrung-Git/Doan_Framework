function Validator(options){
    var selectorRules={};
    function validate(inputElement,rule){
        var errorMessage;
        var errorElement=inputElement.parentElement.querySelector(options.errorForm)
        var rules=selectorRules[rule.selector];
        for(var i=0;i<rules.length;i++){
            errorMessage=rules[i](inputElement.value);
            if(errorMessage) break;
        }
            if(errorMessage){
                errorElement.innerText=errorMessage;
                inputElement.parentElement.classList.add('invalid')
            }else{
                errorElement.innerHTML='';
                inputElement.parentElement.classList.remove('invalid')
            }
            return !errorMessage
    }
    var formElement=document.querySelector(options.form)
    if(formElement){
        formElement.onsubmit = function(e){
            e.preventDefault()
            var isFormValid = true;
            options.rules.forEach(function (rule){
                var inputElement=formElement.querySelector(rule.selector)
                var isValid = validate(inputElement,rule);
                if(!isValid){
                    isFormValid = false
                }
            })
            if (isFormValid){
                if(typeof options.onSubmit === 'function'){
                    var enableInputs = formElement.querySelectorAll('[name]')
                    var formValues=Array.from(enableInputs).reduce(function (values,input){
                        return (values[input.name]=input.value) && values;
                    },{})
                    options.onSubmit(formValues)
                }
                else{
                    formElement.submit();
                }
            }
        }
        options.rules.forEach(function(rule){
            if(Array.isArray(selectorRules[rule.selector])){
                selectorRules[rule.selector].push(rule.test)
            }else{
                selectorRules[rule.selector]=[rule.test]
            }
            var inputElement=formElement.querySelector(rule.selector)
            var errorElement=inputElement.parentElement.querySelector(options.errorForm)
            if(inputElement){
                inputElement.onblur=function(){
                    validate(inputElement,rule)
                }
                inputElement.oninput=function(){
                errorElement.innerHTML='';  
                inputElement.parentElement.classList.remove('invalid')
                }
            }
        })
    }
}
Validator.isRequired=function(selector,message){
   return {
       selector,
       test:function(value){
            return value.trim()?undefined:message||"Vui lòng không bỏ trống"
       }
   }

}
Validator.isEmail=function(selector,message){
    return {
        selector,
        test:function(value){
             const regex = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
             return regex.test(value)?undefined:message||"Trường này phải là email"
        }
    }
  }
  Validator.isPhone=function(selector,message){
    return {
        selector,
        test:function(value){
             const regex = /^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$/
             return regex.test(value)?undefined:message||"Trường này phải là số điện thoại"
        }
    }
  }
  Validator.isUrl=function(selector,message){
    return {
        selector,
        test:function(value){
             const regex = /(https?:\/\/.*\.(?:png|jpg))/i
             return regex.test(value)?undefined:message||"Trường này phải là url hình ảnh"
        }
    }
  }
  Validator.isMinLength=function(selector,min,message){
    return {
        selector,
        test:function(value){
            return value.length>=min?undefined:message||`Mật khẩu tối thiểu phải ${min} kí tự`
        }
    }
  }
  Validator.isConfirmed=function(selector,getConfirmValue,message){
    return {
        selector,
        test:function(value){
            return value===getConfirmValue()?undefined:message||"Giá trị nhập vào không chính xác"
        }
    }
  }

