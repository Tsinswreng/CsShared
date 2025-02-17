namespace Shr.ViewModel.IF;

public interface I_ViewModel<T_Model>{
	public zero fromModel(T_Model model);
	public T_Model toModel();
}
