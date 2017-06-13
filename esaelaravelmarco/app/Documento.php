<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Documento extends Model
{
	protected $table = "friends";
	protected $primaryKey = "id";
	protected $fillable = array("name", "age");
	public $timestamps = true;
	
	public function cursos()
	{
		return $this->belongsToMany('App\Curso', 'curso_documento')->withTimestamps();
	}
}
