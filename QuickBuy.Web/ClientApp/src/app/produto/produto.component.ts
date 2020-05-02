import { Component } from "@angular/core"

@Component({
  selector: "produto",// qual nome da TAG em HTML meu produto componente sera renderizado
  template: "<html><body>{{obterNome()}}</body></html>"
})

export class ProdutoComponent {//nome das classe comecando com maiusculo por conta da conenvao Pascalcase
  //camelCase para variaveis, atributo e nome das funcoes
  id: number;
  public nome: string;
  public liberadoParaVenda: boolean;
  preco: number;

  public obterNome(): string {
    return "Sansung";
  }
}
