<?php

namespace App;

use Illuminate\Database\Eloquent\Model;


class Curso extends Model
{
	protected $table = "cursos";
	protected $primaryKey = "id";
	protected $fillable = array("nome", "tipodecurso", "responsavel", "descricao", "email", "telefone");
	public $timestamps = true;
	
	public function disciplinas()
	{
		return $this->belongsToMany('App\Disciplina1', 'curso_disciplina')->withTimestamps();
	}
	
	public function documentos()
	{
		return $this->belongsToMany('App\Documento1', 'curso_documento')->withTimestamps();
	}
	public function eventos()
	{
		return $this->belongsToMany('App\Evento1', 'curso_evento')->withTimestamps();
	}
	public function propinas()
	{
		return $this->belongsToMany('App\Propina1', 'curso_propina')->withTimestamps();
	}
	
	public function utilizadores()
	{
		return $this->belongsToMany('App\Utilizador1', 'curso_utilizador')->withTimestamps();
	}
	
}
