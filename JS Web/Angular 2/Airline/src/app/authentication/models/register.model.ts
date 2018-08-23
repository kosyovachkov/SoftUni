export class RegisterModel {
  constructor(
    public username: string,
    public email: string,
    public password: string,
    public isAdmin: boolean,
    public isOperator: boolean,
  ) {}
}
