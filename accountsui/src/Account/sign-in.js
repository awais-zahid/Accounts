import React, { Component } from 'react';
import $ from 'jquery';

class SignIn extends Component 
{
    render()
    {
        $(document).ready(function (e) 
        {
            $('#sign-in-form').on(
            'submit', function (e){
                e.preventDefault();
                var states = this;
                var data = {
                    username: $('#username').val(),
                    password: $('#password').val()
                }
                $.ajax({
                    type: 'post',
                    url: 'http://localhost:8080/api/accounts/signin',
                    data:data ,
                    

                    success: function (response) {
                        console.log("AlhamduLillah Got Data from Server");
                        if (states.response === true) {
                            alert('User signed in successfully');
                        }
                        else {
                            alert('please enter correct user name and password');
                        }
                    },
                    error: function (response) {
                        console.clear();
                        console.log(response);

                        alert('"SERVER ERROR : Please check CORS extension if its enabled and  server is running"');

                    }
                });        

            }
            );
        });    

        return(
            <div className="container" style={{ marginTop: "150px"}} >
                <form onSubmit={this.handleSubmit} id = "sign-in-form">
                    <label htmlFor = "username" > User Name</label>
                    <br />
                    <input type="Text" name="username" id = "username" placeholder="User Name"/>
                    <br/>
                    <label htmlFor="password" > Password</label>
                    <br />
                    <input type="password" name="password"  id = "password" placeholder="Password" />
                    <br/>
                    <input type="submit" />
                </form>
            </div>
        )
    }   
}
export default SignIn;