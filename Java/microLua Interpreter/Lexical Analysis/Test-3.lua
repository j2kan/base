-- Test-3.lua

-- Modification on test 5 with invalid identifer cons_my_list_.

require "List";

local my_list;

function cons_my_list_ (r)
  if r <= 10 then
    my_list = List . cons (r, my_list);
    my_list = cons_my_list (r + 1);
  end;
  return my_list;
end

do
  local r;
  r = 1;
  my_list = nil;
  my_list = cons_my_list (r);
  print (List . head (my_list));
end
