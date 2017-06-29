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
		return $this->belongsToMany('App\Disciplina', 'curso_disciplina')->withTimestamps();
	}
	
	public function documentos()
	{
		return $this->belongsToMany('App\Documento', 'curso_documento')->withTimestamps();
	}
	public function eventos()
	{
		return $this->belongsToMany('App\Evento', 'curso_evento')->withTimestamps();
	}
	public function propinas()
	{
		return $this->belongsToMany('App\Propina', 'curso_propina')->withTimestamps();
	}
	
	public function utilizadores()
	{
		return $this->belongsToMany('App\Utilizador', 'curso_utilizador')->withTimestamps();
	}
	
}
