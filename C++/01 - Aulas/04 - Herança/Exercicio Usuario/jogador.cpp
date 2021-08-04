// Classe filha Jogador

class Jogador: public Usuario{
	private:
		int Pontos;
		int Ranking;
	public:
		Jogador();
		void setPontos(int valor);
		void setRanking(int valor);
		
		int getPontos();
		int getRanking();
		
		void acumulaPontos(int valor);
		void exibeDadosJog();
		void alteraRanking(int valor);
};

Jogador::Jogador(){
	Pontos = 0;
	Ranking = 0;
}

void Jogador::setPontos(int valor){
	Pontos = valor;
};

void Jogador::setRanking(int valor){
	Ranking = valor;
};

int Jogador::getPontos(){
	return Pontos;
};

int Jogador::getRanking(){
	return Ranking;
};

void Jogador::acumulaPontos(int valor){
	setPontos(getPontos() + valor);
};

void Jogador::alteraRanking(int valor){
	setRanking(getRanking() + valor);
};

void Jogador::exibeDadosJog(int valor){
	cout<<"Pontos: 	"<<getPontos()<<endl;
	cout<<"Ranking: "<<getRanking()<<endl;
};
