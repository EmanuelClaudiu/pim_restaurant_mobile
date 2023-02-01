export class Sala {
  id: number;
  denumireSala: string;

  constructor(sala: any) {
    this.id = sala.id;
    this.denumireSala = sala.denumireSala;
  }
}
