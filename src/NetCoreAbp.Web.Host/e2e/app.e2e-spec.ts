import { NetCoreAbpTemplatePage } from './app.po';

describe('NetCoreAbp App', function() {
  let page: NetCoreAbpTemplatePage;

  beforeEach(() => {
    page = new NetCoreAbpTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
